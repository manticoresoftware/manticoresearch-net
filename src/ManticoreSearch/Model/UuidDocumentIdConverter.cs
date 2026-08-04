using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ManticoreSearch.Model
{
    /// <summary>Implemented by models that support numeric and UUID document IDs.</summary>
    public interface IUuidDocumentId
    {
        string Uuid { get; set; }
    }

    /// <summary>Maps the single Manticore wire ID to numeric ID or UUID companion.</summary>
    public sealed class UuidDocumentIdConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => typeof(IUuidDocumentId).IsAssignableFrom(objectType);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var payload = JObject.Load(reader);
            var wireKey = WireKey(objectType);
            var wireId = payload[wireKey];
            var model = (IUuidDocumentId)CreateModel(objectType);
            if (wireId != null && wireId.Type == JTokenType.String)
            {
                payload.Remove(wireKey);
                serializer.Populate(payload.CreateReader(), model);
                model.Uuid = wireId.Value<string>();
                return model;
            }
            serializer.Populate(payload.CreateReader(), model);
            return model;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var payload = new JObject();
            var model = (IUuidDocumentId)value;
            var wireKey = WireKey(value.GetType());
            foreach (var property in value.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public))
            {
                var dataMember = property.GetCustomAttribute<DataMemberAttribute>();
                if (dataMember == null || property.Name == nameof(IUuidDocumentId.Uuid))
                    continue;
                if (dataMember.Name == wireKey)
                    continue;
                var propertyValue = property.GetValue(value);
                if (IsOmitted(property, dataMember, propertyValue))
                    continue;
                payload[dataMember.Name] = JToken.FromObject(propertyValue, serializer);
            }
            if (model.Uuid != null)
                payload[wireKey] = model.Uuid;
            else
            {
                var idProp = value.GetType().GetProperty("Id") ?? value.GetType().GetProperty("DocId");
                if (idProp != null)
                {
                    var idVal = idProp.GetValue(value);
                    var idMember = idProp.GetCustomAttribute<DataMemberAttribute>();
                    if (!IsOmitted(idProp, idMember, idVal))
                        payload[wireKey] = JToken.FromObject(idVal, serializer);
                }
            }
            payload.WriteTo(writer);
        }

        private static object CreateModel(Type objectType)
        {
            var parameterless = objectType.GetConstructor(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                binder: null,
                types: Type.EmptyTypes,
                modifiers: null);
            if (parameterless != null)
                return parameterless.Invoke(null);

            // OpenAPI models often only declare ctors whose every argument is optional.
            return Activator.CreateInstance(
                objectType,
                BindingFlags.CreateInstance | BindingFlags.Public | BindingFlags.Instance | BindingFlags.OptionalParamBinding,
                binder: null,
                args: null,
                culture: CultureInfo.InvariantCulture);
        }

        private static bool IsOmitted(PropertyInfo property, DataMemberAttribute dataMember, object propertyValue)
        {
            if (propertyValue == null)
                return true;
            if (dataMember != null && !dataMember.EmitDefaultValue && property.PropertyType.IsValueType)
            {
                var defaultValue = Activator.CreateInstance(property.PropertyType);
                if (Equals(propertyValue, defaultValue))
                    return true;
            }
            return false;
        }

        private static string WireKey(Type type)
        {
            if (type == typeof(HitsHits)) return "_id";
            if (type == typeof(Knn)) return "doc_id";
            return "id";
        }
    }
}

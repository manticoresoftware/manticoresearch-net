/*
 * Manticore Search Client
 *
 * Сlient for Manticore Search. 
 *
 * The version of the OpenAPI document: 5.0.0
 * Contact: info@manticoresearch.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = ManticoreSearch.Client.FileParameter;
using OpenAPIDateConverter = ManticoreSearch.Client.OpenAPIDateConverter;

namespace ManticoreSearch.Model
{
    /// <summary>
    /// Object representing a term to be used in composite aggregation.
    /// </summary>
    [DataContract(Name = "aggCompositeTerm")]
    public partial class AggCompositeTerm : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggCompositeTerm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AggCompositeTerm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AggCompositeTerm" /> class.
        /// </summary>
        /// <param name="Field">Name of field to operate with (required).</param>
        public AggCompositeTerm(string Field = default(string))
        {
            // to ensure "Field" is required (not null)
            if (Field == null)
            {
                throw new ArgumentNullException("Field is a required property for AggCompositeTerm and cannot be null");
            }
            this.Field = Field;
        }

        /// <summary>
        /// Name of field to operate with
        /// </summary>
        /// <value>Name of field to operate with</value>
        /// <example>field1</example>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public string Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AggCompositeTerm {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
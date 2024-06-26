/*
 * Manticore Search Client
 *
 * Сlient for Manticore Search. 
 *
 * The version of the OpenAPI document: 3.3.1
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
    /// AggregationCompositeSourcesInnerValueTerms
    /// </summary>
    [DataContract(Name = "aggregation_composite_sources_inner_value_terms")]
    public partial class AggregationCompositeSourcesInnerValueTerms : IEquatable<AggregationCompositeSourcesInnerValueTerms>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AggregationCompositeSourcesInnerValueTerms" /> class.
        /// </summary>
        /// <param name="field">Name of attribute to aggregate by.</param>
        public AggregationCompositeSourcesInnerValueTerms(string field = default(string))
        {
            this.Field = field;
        }

        /// <summary>
        /// Name of attribute to aggregate by
        /// </summary>
        /// <value>Name of attribute to aggregate by</value>
        [DataMember(Name = "field", EmitDefaultValue = false)]
        public string Field { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AggregationCompositeSourcesInnerValueTerms {\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AggregationCompositeSourcesInnerValueTerms);
        }

        /// <summary>
        /// Returns true if AggregationCompositeSourcesInnerValueTerms instances are equal
        /// </summary>
        /// <param name="input">Instance of AggregationCompositeSourcesInnerValueTerms to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AggregationCompositeSourcesInnerValueTerms input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Field != null)
                {
                    hashCode = (hashCode * 59) + this.Field.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

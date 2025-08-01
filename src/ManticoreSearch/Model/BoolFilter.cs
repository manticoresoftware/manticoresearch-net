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
    /// BoolFilter
    /// </summary>
    [DataContract(Name = "boolFilter")]
    public partial class BoolFilter : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoolFilter" /> class.
        /// </summary>
        /// <param name="must">Query clauses that must match for the document to be included.</param>
        /// <param name="mustNot">Query clauses that must not match for the document to be included.</param>
        /// <param name="should">Query clauses that should be matched, but are not required.</param>
        public BoolFilter(List<QueryFilter> must = default, List<QueryFilter> mustNot = default, List<QueryFilter> should = default)
        {
            this.Must = must;
            this.MustNot = mustNot;
            this.Should = should;
        }

        /// <summary>
        /// Query clauses that must match for the document to be included
        /// </summary>
        /// <value>Query clauses that must match for the document to be included</value>
        [DataMember(Name = "must", EmitDefaultValue = false)]
        public List<QueryFilter> Must { get; set; }

        /// <summary>
        /// Query clauses that must not match for the document to be included
        /// </summary>
        /// <value>Query clauses that must not match for the document to be included</value>
        [DataMember(Name = "must_not", EmitDefaultValue = false)]
        public List<QueryFilter> MustNot { get; set; }

        /// <summary>
        /// Query clauses that should be matched, but are not required
        /// </summary>
        /// <value>Query clauses that should be matched, but are not required</value>
        [DataMember(Name = "should", EmitDefaultValue = false)]
        public List<QueryFilter> Should { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BoolFilter {\n");
            sb.Append("  Must: ").Append(Must).Append("\n");
            sb.Append("  MustNot: ").Append(MustNot).Append("\n");
            sb.Append("  Should: ").Append(Should).Append("\n");
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

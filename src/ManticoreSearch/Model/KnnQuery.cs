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
    /// Object representing a k-nearest neighbor search query
    /// </summary>
    [DataContract(Name = "knnQuery")]
    public partial class KnnQuery : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KnnQuery" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected KnnQuery() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="KnnQuery" /> class.
        /// </summary>
        /// <param name="field">Field to perform the k-nearest neighbor search on (required).</param>
        /// <param name="k">The number of nearest neighbors to return (required).</param>
        /// <param name="queryVector">The vector used as input for the KNN search.</param>
        /// <param name="docId">The docuemnt ID used as input for the KNN search.</param>
        /// <param name="ef">Optional parameter controlling the accuracy of the search.</param>
        /// <param name="filter">filter.</param>
        public KnnQuery(string field = default, int k = default, List<decimal> queryVector = default, UInt64 docId = default, int ef = default, QueryFilter filter = default)
        {
            // to ensure "field" is required (not null)
            if (field == null)
            {
                throw new ArgumentNullException("field is a required property for KnnQuery and cannot be null");
            }
            this.Field = field;
            this.K = k;
            this.QueryVector = queryVector;
            this.DocId = docId;
            this.Ef = ef;
            this.Filter = filter;
        }

        /// <summary>
        /// Field to perform the k-nearest neighbor search on
        /// </summary>
        /// <value>Field to perform the k-nearest neighbor search on</value>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public string Field { get; set; }

        /// <summary>
        /// The number of nearest neighbors to return
        /// </summary>
        /// <value>The number of nearest neighbors to return</value>
        [DataMember(Name = "k", IsRequired = true, EmitDefaultValue = true)]
        public int K { get; set; }

        /// <summary>
        /// The vector used as input for the KNN search
        /// </summary>
        /// <value>The vector used as input for the KNN search</value>
        [DataMember(Name = "query_vector", EmitDefaultValue = false)]
        public List<decimal> QueryVector { get; set; }

        /// <summary>
        /// The docuemnt ID used as input for the KNN search
        /// </summary>
        /// <value>The docuemnt ID used as input for the KNN search</value>
        [DataMember(Name = "doc_id", EmitDefaultValue = false)]
        public UInt64 DocId { get; set; }

        /// <summary>
        /// Optional parameter controlling the accuracy of the search
        /// </summary>
        /// <value>Optional parameter controlling the accuracy of the search</value>
        [DataMember(Name = "ef", EmitDefaultValue = false)]
        public int Ef { get; set; }

        /// <summary>
        /// Gets or Sets Filter
        /// </summary>
        [DataMember(Name = "filter", EmitDefaultValue = false)]
        public QueryFilter Filter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KnnQuery {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  K: ").Append(K).Append("\n");
            sb.Append("  QueryVector: ").Append(QueryVector).Append("\n");
            sb.Append("  DocId: ").Append(DocId).Append("\n");
            sb.Append("  Ef: ").Append(Ef).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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

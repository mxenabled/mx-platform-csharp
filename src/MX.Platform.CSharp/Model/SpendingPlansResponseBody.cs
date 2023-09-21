/*
 * MX Platform API
 *
 * The MX Platform API is a powerful, fully-featured API designed to make aggregating and enhancing financial data easy and reliable. It can seamlessly connect your app or website to tens of thousands of financial institutions.
 *
 * The version of the OpenAPI document: 0.1.0
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
using OpenAPIDateConverter = MX.Platform.CSharp.Client.OpenAPIDateConverter;

namespace MX.Platform.CSharp.Model
{
    /// <summary>
    /// SpendingPlansResponseBody
    /// </summary>
    [DataContract(Name = "SpendingPlansResponseBody")]
    public partial class SpendingPlansResponseBody : IEquatable<SpendingPlansResponseBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingPlansResponseBody" /> class.
        /// </summary>
        /// <param name="iterationItems">iterationItems.</param>
        /// <param name="pagination">pagination.</param>
        public SpendingPlansResponseBody(List<SpendingPlanResponse> iterationItems = default(List<SpendingPlanResponse>), PaginationResponse pagination = default(PaginationResponse))
        {
            this.IterationItems = iterationItems;
            this.Pagination = pagination;
        }

        /// <summary>
        /// Gets or Sets IterationItems
        /// </summary>
        [DataMember(Name = "iteration_items", EmitDefaultValue = false)]
        public List<SpendingPlanResponse> IterationItems { get; set; }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public PaginationResponse Pagination { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpendingPlansResponseBody {\n");
            sb.Append("  IterationItems: ").Append(IterationItems).Append("\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
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
            return this.Equals(input as SpendingPlansResponseBody);
        }

        /// <summary>
        /// Returns true if SpendingPlansResponseBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SpendingPlansResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpendingPlansResponseBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IterationItems == input.IterationItems ||
                    this.IterationItems != null &&
                    input.IterationItems != null &&
                    this.IterationItems.SequenceEqual(input.IterationItems)
                ) && 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
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
                if (this.IterationItems != null)
                {
                    hashCode = (hashCode * 59) + this.IterationItems.GetHashCode();
                }
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
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
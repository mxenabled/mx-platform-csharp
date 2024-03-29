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
    /// PaginationResponse
    /// </summary>
    [DataContract(Name = "PaginationResponse")]
    public partial class PaginationResponse : IEquatable<PaginationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponse" /> class.
        /// </summary>
        /// <param name="currentPage">currentPage.</param>
        /// <param name="perPage">perPage.</param>
        /// <param name="totalEntries">totalEntries.</param>
        /// <param name="totalPages">totalPages.</param>
        public PaginationResponse(int currentPage = default(int), int perPage = default(int), int totalEntries = default(int), int totalPages = default(int))
        {
            this.CurrentPage = currentPage;
            this.PerPage = perPage;
            this.TotalEntries = totalEntries;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// Gets or Sets CurrentPage
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "current_page", EmitDefaultValue = false)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// Gets or Sets PerPage
        /// </summary>
        /// <example>25</example>
        [DataMember(Name = "per_page", EmitDefaultValue = false)]
        public int PerPage { get; set; }

        /// <summary>
        /// Gets or Sets TotalEntries
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "total_entries", EmitDefaultValue = false)]
        public int TotalEntries { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaginationResponse {\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  TotalEntries: ").Append(TotalEntries).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
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
            return this.Equals(input as PaginationResponse);
        }

        /// <summary>
        /// Returns true if PaginationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaginationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentPage == input.CurrentPage ||
                    this.CurrentPage.Equals(input.CurrentPage)
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    this.PerPage.Equals(input.PerPage)
                ) && 
                (
                    this.TotalEntries == input.TotalEntries ||
                    this.TotalEntries.Equals(input.TotalEntries)
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
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
                hashCode = (hashCode * 59) + this.CurrentPage.GetHashCode();
                hashCode = (hashCode * 59) + this.PerPage.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalEntries.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPages.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

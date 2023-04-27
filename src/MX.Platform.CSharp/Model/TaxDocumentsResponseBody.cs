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
    /// TaxDocumentsResponseBody
    /// </summary>
    [DataContract(Name = "TaxDocumentsResponseBody")]
    public partial class TaxDocumentsResponseBody : IEquatable<TaxDocumentsResponseBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxDocumentsResponseBody" /> class.
        /// </summary>
        /// <param name="pagination">pagination.</param>
        /// <param name="taxDocuments">taxDocuments.</param>
        public TaxDocumentsResponseBody(PaginationResponse pagination = default(PaginationResponse), List<TaxDocumentResponse> taxDocuments = default(List<TaxDocumentResponse>))
        {
            this.Pagination = pagination;
            this.TaxDocuments = taxDocuments;
        }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public PaginationResponse Pagination { get; set; }

        /// <summary>
        /// Gets or Sets TaxDocuments
        /// </summary>
        [DataMember(Name = "tax_documents", EmitDefaultValue = false)]
        public List<TaxDocumentResponse> TaxDocuments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxDocumentsResponseBody {\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  TaxDocuments: ").Append(TaxDocuments).Append("\n");
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
            return this.Equals(input as TaxDocumentsResponseBody);
        }

        /// <summary>
        /// Returns true if TaxDocumentsResponseBody instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxDocumentsResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxDocumentsResponseBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.TaxDocuments == input.TaxDocuments ||
                    this.TaxDocuments != null &&
                    input.TaxDocuments != null &&
                    this.TaxDocuments.SequenceEqual(input.TaxDocuments)
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
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
                }
                if (this.TaxDocuments != null)
                {
                    hashCode = (hashCode * 59) + this.TaxDocuments.GetHashCode();
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

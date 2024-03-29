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
    /// TaxDocumentResponse
    /// </summary>
    [DataContract(Name = "TaxDocumentResponse")]
    public partial class TaxDocumentResponse : IEquatable<TaxDocumentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxDocumentResponse" /> class.
        /// </summary>
        /// <param name="contentHash">contentHash.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="documentType">documentType.</param>
        /// <param name="guid">guid.</param>
        /// <param name="issuedOn">issuedOn.</param>
        /// <param name="memberGuid">memberGuid.</param>
        /// <param name="taxYear">taxYear.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="uri">uri.</param>
        /// <param name="userGuid">userGuid.</param>
        public TaxDocumentResponse(string contentHash = default(string), string createdAt = default(string), string documentType = default(string), string guid = default(string), string issuedOn = default(string), string memberGuid = default(string), string taxYear = default(string), string updatedAt = default(string), string uri = default(string), string userGuid = default(string))
        {
            this.ContentHash = contentHash;
            this.CreatedAt = createdAt;
            this.DocumentType = documentType;
            this.Guid = guid;
            this.IssuedOn = issuedOn;
            this.MemberGuid = memberGuid;
            this.TaxYear = taxYear;
            this.UpdatedAt = updatedAt;
            this.Uri = uri;
            this.UserGuid = userGuid;
        }

        /// <summary>
        /// Gets or Sets ContentHash
        /// </summary>
        /// <example>a16c580c4fcdfa8088edaa7b4d35b290</example>
        [DataMember(Name = "content_hash", EmitDefaultValue = true)]
        public string ContentHash { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        /// <example>2022-10-18T19:23:16Z</example>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets DocumentType
        /// </summary>
        /// <example>TAX1099_C</example>
        [DataMember(Name = "document_type", EmitDefaultValue = true)]
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        /// <example>TAX-ee8776ea-468b-4b02-b95d-743adf6ba50e</example>
        [DataMember(Name = "guid", EmitDefaultValue = true)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets IssuedOn
        /// </summary>
        /// <example>2022-03-31</example>
        [DataMember(Name = "issued_on", EmitDefaultValue = true)]
        public string IssuedOn { get; set; }

        /// <summary>
        /// Gets or Sets MemberGuid
        /// </summary>
        /// <example>MBR-7c6f361b-e582-15b6-60c0-358f12466b4b</example>
        [DataMember(Name = "member_guid", EmitDefaultValue = true)]
        public string MemberGuid { get; set; }

        /// <summary>
        /// Gets or Sets TaxYear
        /// </summary>
        /// <example>2023</example>
        [DataMember(Name = "tax_year", EmitDefaultValue = true)]
        public string TaxYear { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        /// <example>2022-10-18T19:23:16Z</example>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        /// <example>/users/USR-11141024-90b3-1bce-cac9-c06ced52ab4c/members/MBR-7c6f361b-e582-15b6-60c0-358f12466b4b/tax_documents/TAX-ee8776ea-468b-4b02-b95d-743adf6ba50e.pdf</example>
        [DataMember(Name = "uri", EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets UserGuid
        /// </summary>
        /// <example>USR-11141024-90b3-1bce-cac9-c06ced52ab4c</example>
        [DataMember(Name = "user_guid", EmitDefaultValue = true)]
        public string UserGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxDocumentResponse {\n");
            sb.Append("  ContentHash: ").Append(ContentHash).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  IssuedOn: ").Append(IssuedOn).Append("\n");
            sb.Append("  MemberGuid: ").Append(MemberGuid).Append("\n");
            sb.Append("  TaxYear: ").Append(TaxYear).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Uri: ").Append(Uri).Append("\n");
            sb.Append("  UserGuid: ").Append(UserGuid).Append("\n");
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
            return this.Equals(input as TaxDocumentResponse);
        }

        /// <summary>
        /// Returns true if TaxDocumentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxDocumentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxDocumentResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentHash == input.ContentHash ||
                    (this.ContentHash != null &&
                    this.ContentHash.Equals(input.ContentHash))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.IssuedOn == input.IssuedOn ||
                    (this.IssuedOn != null &&
                    this.IssuedOn.Equals(input.IssuedOn))
                ) && 
                (
                    this.MemberGuid == input.MemberGuid ||
                    (this.MemberGuid != null &&
                    this.MemberGuid.Equals(input.MemberGuid))
                ) && 
                (
                    this.TaxYear == input.TaxYear ||
                    (this.TaxYear != null &&
                    this.TaxYear.Equals(input.TaxYear))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Uri == input.Uri ||
                    (this.Uri != null &&
                    this.Uri.Equals(input.Uri))
                ) && 
                (
                    this.UserGuid == input.UserGuid ||
                    (this.UserGuid != null &&
                    this.UserGuid.Equals(input.UserGuid))
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
                if (this.ContentHash != null)
                {
                    hashCode = (hashCode * 59) + this.ContentHash.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.DocumentType != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentType.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.IssuedOn != null)
                {
                    hashCode = (hashCode * 59) + this.IssuedOn.GetHashCode();
                }
                if (this.MemberGuid != null)
                {
                    hashCode = (hashCode * 59) + this.MemberGuid.GetHashCode();
                }
                if (this.TaxYear != null)
                {
                    hashCode = (hashCode * 59) + this.TaxYear.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
                }
                if (this.Uri != null)
                {
                    hashCode = (hashCode * 59) + this.Uri.GetHashCode();
                }
                if (this.UserGuid != null)
                {
                    hashCode = (hashCode * 59) + this.UserGuid.GetHashCode();
                }
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

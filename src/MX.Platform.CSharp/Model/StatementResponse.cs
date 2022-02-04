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
    /// StatementResponse
    /// </summary>
    [DataContract(Name = "StatementResponse")]
    public partial class StatementResponse : IEquatable<StatementResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StatementResponse" /> class.
        /// </summary>
        /// <param name="accountGuid">accountGuid.</param>
        /// <param name="contentHash">contentHash.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="guid">guid.</param>
        /// <param name="memberGuid">memberGuid.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="uri">uri.</param>
        /// <param name="userGuid">userGuid.</param>
        public StatementResponse(string accountGuid = default(string), string contentHash = default(string), string createdAt = default(string), string guid = default(string), string memberGuid = default(string), string updatedAt = default(string), string uri = default(string), string userGuid = default(string))
        {
            this.AccountGuid = accountGuid;
            this.ContentHash = contentHash;
            this.CreatedAt = createdAt;
            this.Guid = guid;
            this.MemberGuid = memberGuid;
            this.UpdatedAt = updatedAt;
            this.Uri = uri;
            this.UserGuid = userGuid;
        }

        /// <summary>
        /// Gets or Sets AccountGuid
        /// </summary>
        [DataMember(Name = "account_guid", EmitDefaultValue = true)]
        public string AccountGuid { get; set; }

        /// <summary>
        /// Gets or Sets ContentHash
        /// </summary>
        [DataMember(Name = "content_hash", EmitDefaultValue = true)]
        public string ContentHash { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name = "guid", EmitDefaultValue = true)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets MemberGuid
        /// </summary>
        [DataMember(Name = "member_guid", EmitDefaultValue = true)]
        public string MemberGuid { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Uri
        /// </summary>
        [DataMember(Name = "uri", EmitDefaultValue = true)]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or Sets UserGuid
        /// </summary>
        [DataMember(Name = "user_guid", EmitDefaultValue = true)]
        public string UserGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StatementResponse {\n");
            sb.Append("  AccountGuid: ").Append(AccountGuid).Append("\n");
            sb.Append("  ContentHash: ").Append(ContentHash).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  MemberGuid: ").Append(MemberGuid).Append("\n");
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
            return this.Equals(input as StatementResponse);
        }

        /// <summary>
        /// Returns true if StatementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StatementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatementResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountGuid == input.AccountGuid ||
                    (this.AccountGuid != null &&
                    this.AccountGuid.Equals(input.AccountGuid))
                ) && 
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
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.MemberGuid == input.MemberGuid ||
                    (this.MemberGuid != null &&
                    this.MemberGuid.Equals(input.MemberGuid))
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
                if (this.AccountGuid != null)
                {
                    hashCode = (hashCode * 59) + this.AccountGuid.GetHashCode();
                }
                if (this.ContentHash != null)
                {
                    hashCode = (hashCode * 59) + this.ContentHash.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.MemberGuid != null)
                {
                    hashCode = (hashCode * 59) + this.MemberGuid.GetHashCode();
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

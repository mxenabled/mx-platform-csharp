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
    /// InstitutionResponse
    /// </summary>
    [DataContract(Name = "InstitutionResponse")]
    public partial class InstitutionResponse : IEquatable<InstitutionResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InstitutionResponse" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="instructionalText">instructionalText.</param>
        /// <param name="mediumLogoUrl">mediumLogoUrl.</param>
        /// <param name="name">name.</param>
        /// <param name="smallLogoUrl">smallLogoUrl.</param>
        /// <param name="supportsAccountIdentification">supportsAccountIdentification.</param>
        /// <param name="supportsAccountStatement">supportsAccountStatement.</param>
        /// <param name="supportsAccountVerification">supportsAccountVerification.</param>
        /// <param name="supportsOauth">supportsOauth.</param>
        /// <param name="supportsTransactionHistory">supportsTransactionHistory.</param>
        /// <param name="url">url.</param>
        public InstitutionResponse(string code = default(string), string instructionalText = default(string), string mediumLogoUrl = default(string), string name = default(string), string smallLogoUrl = default(string), bool? supportsAccountIdentification = default(bool?), bool? supportsAccountStatement = default(bool?), bool? supportsAccountVerification = default(bool?), bool? supportsOauth = default(bool?), bool? supportsTransactionHistory = default(bool?), string url = default(string))
        {
            this.Code = code;
            this.InstructionalText = instructionalText;
            this.MediumLogoUrl = mediumLogoUrl;
            this.Name = name;
            this.SmallLogoUrl = smallLogoUrl;
            this.SupportsAccountIdentification = supportsAccountIdentification;
            this.SupportsAccountStatement = supportsAccountStatement;
            this.SupportsAccountVerification = supportsAccountVerification;
            this.SupportsOauth = supportsOauth;
            this.SupportsTransactionHistory = supportsTransactionHistory;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets InstructionalText
        /// </summary>
        [DataMember(Name = "instructional_text", EmitDefaultValue = true)]
        public string InstructionalText { get; set; }

        /// <summary>
        /// Gets or Sets MediumLogoUrl
        /// </summary>
        [DataMember(Name = "medium_logo_url", EmitDefaultValue = true)]
        public string MediumLogoUrl { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets SmallLogoUrl
        /// </summary>
        [DataMember(Name = "small_logo_url", EmitDefaultValue = true)]
        public string SmallLogoUrl { get; set; }

        /// <summary>
        /// Gets or Sets SupportsAccountIdentification
        /// </summary>
        [DataMember(Name = "supports_account_identification", EmitDefaultValue = true)]
        public bool? SupportsAccountIdentification { get; set; }

        /// <summary>
        /// Gets or Sets SupportsAccountStatement
        /// </summary>
        [DataMember(Name = "supports_account_statement", EmitDefaultValue = true)]
        public bool? SupportsAccountStatement { get; set; }

        /// <summary>
        /// Gets or Sets SupportsAccountVerification
        /// </summary>
        [DataMember(Name = "supports_account_verification", EmitDefaultValue = true)]
        public bool? SupportsAccountVerification { get; set; }

        /// <summary>
        /// Gets or Sets SupportsOauth
        /// </summary>
        [DataMember(Name = "supports_oauth", EmitDefaultValue = true)]
        public bool? SupportsOauth { get; set; }

        /// <summary>
        /// Gets or Sets SupportsTransactionHistory
        /// </summary>
        [DataMember(Name = "supports_transaction_history", EmitDefaultValue = true)]
        public bool? SupportsTransactionHistory { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InstitutionResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  InstructionalText: ").Append(InstructionalText).Append("\n");
            sb.Append("  MediumLogoUrl: ").Append(MediumLogoUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  SmallLogoUrl: ").Append(SmallLogoUrl).Append("\n");
            sb.Append("  SupportsAccountIdentification: ").Append(SupportsAccountIdentification).Append("\n");
            sb.Append("  SupportsAccountStatement: ").Append(SupportsAccountStatement).Append("\n");
            sb.Append("  SupportsAccountVerification: ").Append(SupportsAccountVerification).Append("\n");
            sb.Append("  SupportsOauth: ").Append(SupportsOauth).Append("\n");
            sb.Append("  SupportsTransactionHistory: ").Append(SupportsTransactionHistory).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as InstitutionResponse);
        }

        /// <summary>
        /// Returns true if InstitutionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of InstitutionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InstitutionResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.InstructionalText == input.InstructionalText ||
                    (this.InstructionalText != null &&
                    this.InstructionalText.Equals(input.InstructionalText))
                ) && 
                (
                    this.MediumLogoUrl == input.MediumLogoUrl ||
                    (this.MediumLogoUrl != null &&
                    this.MediumLogoUrl.Equals(input.MediumLogoUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.SmallLogoUrl == input.SmallLogoUrl ||
                    (this.SmallLogoUrl != null &&
                    this.SmallLogoUrl.Equals(input.SmallLogoUrl))
                ) && 
                (
                    this.SupportsAccountIdentification == input.SupportsAccountIdentification ||
                    (this.SupportsAccountIdentification != null &&
                    this.SupportsAccountIdentification.Equals(input.SupportsAccountIdentification))
                ) && 
                (
                    this.SupportsAccountStatement == input.SupportsAccountStatement ||
                    (this.SupportsAccountStatement != null &&
                    this.SupportsAccountStatement.Equals(input.SupportsAccountStatement))
                ) && 
                (
                    this.SupportsAccountVerification == input.SupportsAccountVerification ||
                    (this.SupportsAccountVerification != null &&
                    this.SupportsAccountVerification.Equals(input.SupportsAccountVerification))
                ) && 
                (
                    this.SupportsOauth == input.SupportsOauth ||
                    (this.SupportsOauth != null &&
                    this.SupportsOauth.Equals(input.SupportsOauth))
                ) && 
                (
                    this.SupportsTransactionHistory == input.SupportsTransactionHistory ||
                    (this.SupportsTransactionHistory != null &&
                    this.SupportsTransactionHistory.Equals(input.SupportsTransactionHistory))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.InstructionalText != null)
                {
                    hashCode = (hashCode * 59) + this.InstructionalText.GetHashCode();
                }
                if (this.MediumLogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.MediumLogoUrl.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.SmallLogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SmallLogoUrl.GetHashCode();
                }
                if (this.SupportsAccountIdentification != null)
                {
                    hashCode = (hashCode * 59) + this.SupportsAccountIdentification.GetHashCode();
                }
                if (this.SupportsAccountStatement != null)
                {
                    hashCode = (hashCode * 59) + this.SupportsAccountStatement.GetHashCode();
                }
                if (this.SupportsAccountVerification != null)
                {
                    hashCode = (hashCode * 59) + this.SupportsAccountVerification.GetHashCode();
                }
                if (this.SupportsOauth != null)
                {
                    hashCode = (hashCode * 59) + this.SupportsOauth.GetHashCode();
                }
                if (this.SupportsTransactionHistory != null)
                {
                    hashCode = (hashCode * 59) + this.SupportsTransactionHistory.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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

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
    /// MemberCreateRequestBody
    /// </summary>
    [DataContract(Name = "MemberCreateRequestBody")]
    public partial class MemberCreateRequestBody : IEquatable<MemberCreateRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberCreateRequestBody" /> class.
        /// </summary>
        /// <param name="member">member.</param>
        /// <param name="referralSource">referralSource.</param>
        /// <param name="uiMessageWebviewUrlScheme">uiMessageWebviewUrlScheme.</param>
        public MemberCreateRequestBody(MemberCreateRequest member = default(MemberCreateRequest), string referralSource = default(string), string uiMessageWebviewUrlScheme = default(string))
        {
            this.Member = member;
            this.ReferralSource = referralSource;
            this.UiMessageWebviewUrlScheme = uiMessageWebviewUrlScheme;
        }

        /// <summary>
        /// Gets or Sets Member
        /// </summary>
        [DataMember(Name = "member", EmitDefaultValue = false)]
        public MemberCreateRequest Member { get; set; }

        /// <summary>
        /// Gets or Sets ReferralSource
        /// </summary>
        [DataMember(Name = "referral_source", EmitDefaultValue = false)]
        public string ReferralSource { get; set; }

        /// <summary>
        /// Gets or Sets UiMessageWebviewUrlScheme
        /// </summary>
        [DataMember(Name = "ui_message_webview_url_scheme", EmitDefaultValue = false)]
        public string UiMessageWebviewUrlScheme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MemberCreateRequestBody {\n");
            sb.Append("  Member: ").Append(Member).Append("\n");
            sb.Append("  ReferralSource: ").Append(ReferralSource).Append("\n");
            sb.Append("  UiMessageWebviewUrlScheme: ").Append(UiMessageWebviewUrlScheme).Append("\n");
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
            return this.Equals(input as MemberCreateRequestBody);
        }

        /// <summary>
        /// Returns true if MemberCreateRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberCreateRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberCreateRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Member == input.Member ||
                    (this.Member != null &&
                    this.Member.Equals(input.Member))
                ) && 
                (
                    this.ReferralSource == input.ReferralSource ||
                    (this.ReferralSource != null &&
                    this.ReferralSource.Equals(input.ReferralSource))
                ) && 
                (
                    this.UiMessageWebviewUrlScheme == input.UiMessageWebviewUrlScheme ||
                    (this.UiMessageWebviewUrlScheme != null &&
                    this.UiMessageWebviewUrlScheme.Equals(input.UiMessageWebviewUrlScheme))
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
                if (this.Member != null)
                {
                    hashCode = (hashCode * 59) + this.Member.GetHashCode();
                }
                if (this.ReferralSource != null)
                {
                    hashCode = (hashCode * 59) + this.ReferralSource.GetHashCode();
                }
                if (this.UiMessageWebviewUrlScheme != null)
                {
                    hashCode = (hashCode * 59) + this.UiMessageWebviewUrlScheme.GetHashCode();
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

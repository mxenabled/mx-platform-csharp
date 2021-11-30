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
using OpenAPIDateConverter = MX.Platform.Client.OpenAPIDateConverter;

namespace MX.Platform.Model
{
    /// <summary>
    /// MemberCreateRequest
    /// </summary>
    [DataContract(Name = "MemberCreateRequest")]
    public partial class MemberCreateRequest : IEquatable<MemberCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MemberCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberCreateRequest" /> class.
        /// </summary>
        /// <param name="backgroundAggregationIsDisabled">backgroundAggregationIsDisabled.</param>
        /// <param name="credentials">credentials (required).</param>
        /// <param name="id">id.</param>
        /// <param name="institutionCode">institutionCode (required).</param>
        /// <param name="isOauth">isOauth.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="skipAggregation">skipAggregation.</param>
        public MemberCreateRequest(bool backgroundAggregationIsDisabled = default(bool), List<CredentialRequest> credentials = default(List<CredentialRequest>), string id = default(string), string institutionCode = default(string), bool isOauth = default(bool), string metadata = default(string), bool skipAggregation = default(bool))
        {
            // to ensure "credentials" is required (not null)
            if (credentials == null) {
                throw new ArgumentNullException("credentials is a required property for MemberCreateRequest and cannot be null");
            }
            this.Credentials = credentials;
            // to ensure "institutionCode" is required (not null)
            if (institutionCode == null) {
                throw new ArgumentNullException("institutionCode is a required property for MemberCreateRequest and cannot be null");
            }
            this.InstitutionCode = institutionCode;
            this.BackgroundAggregationIsDisabled = backgroundAggregationIsDisabled;
            this.Id = id;
            this.IsOauth = isOauth;
            this.Metadata = metadata;
            this.SkipAggregation = skipAggregation;
        }

        /// <summary>
        /// Gets or Sets BackgroundAggregationIsDisabled
        /// </summary>
        [DataMember(Name = "background_aggregation_is_disabled", EmitDefaultValue = true)]
        public bool BackgroundAggregationIsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", IsRequired = true, EmitDefaultValue = false)]
        public List<CredentialRequest> Credentials { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionCode
        /// </summary>
        [DataMember(Name = "institution_code", IsRequired = true, EmitDefaultValue = false)]
        public string InstitutionCode { get; set; }

        /// <summary>
        /// Gets or Sets IsOauth
        /// </summary>
        [DataMember(Name = "is_oauth", EmitDefaultValue = true)]
        public bool IsOauth { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets SkipAggregation
        /// </summary>
        [DataMember(Name = "skip_aggregation", EmitDefaultValue = true)]
        public bool SkipAggregation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MemberCreateRequest {\n");
            sb.Append("  BackgroundAggregationIsDisabled: ").Append(BackgroundAggregationIsDisabled).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstitutionCode: ").Append(InstitutionCode).Append("\n");
            sb.Append("  IsOauth: ").Append(IsOauth).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SkipAggregation: ").Append(SkipAggregation).Append("\n");
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
            return this.Equals(input as MemberCreateRequest);
        }

        /// <summary>
        /// Returns true if MemberCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberCreateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BackgroundAggregationIsDisabled == input.BackgroundAggregationIsDisabled ||
                    this.BackgroundAggregationIsDisabled.Equals(input.BackgroundAggregationIsDisabled)
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    this.Credentials != null &&
                    input.Credentials != null &&
                    this.Credentials.SequenceEqual(input.Credentials)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InstitutionCode == input.InstitutionCode ||
                    (this.InstitutionCode != null &&
                    this.InstitutionCode.Equals(input.InstitutionCode))
                ) && 
                (
                    this.IsOauth == input.IsOauth ||
                    this.IsOauth.Equals(input.IsOauth)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.SkipAggregation == input.SkipAggregation ||
                    this.SkipAggregation.Equals(input.SkipAggregation)
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
                hashCode = hashCode * 59 + this.BackgroundAggregationIsDisabled.GetHashCode();
                if (this.Credentials != null)
                    hashCode = hashCode * 59 + this.Credentials.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InstitutionCode != null)
                    hashCode = hashCode * 59 + this.InstitutionCode.GetHashCode();
                hashCode = hashCode * 59 + this.IsOauth.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                hashCode = hashCode * 59 + this.SkipAggregation.GetHashCode();
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

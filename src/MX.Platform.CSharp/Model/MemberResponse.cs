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
    /// MemberResponse
    /// </summary>
    [DataContract(Name = "MemberResponse")]
    public partial class MemberResponse : IEquatable<MemberResponse>, IValidatableObject
    {
        /// <summary>
        /// Defines UseCases
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UseCasesEnum
        {
            /// <summary>
            /// Enum MONEYMOVEMENT for value: MONEY_MOVEMENT
            /// </summary>
            [EnumMember(Value = "MONEY_MOVEMENT")]
            MONEYMOVEMENT = 1,

            /// <summary>
            /// Enum PFM for value: PFM
            /// </summary>
            [EnumMember(Value = "PFM")]
            PFM = 2
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MemberResponse" /> class.
        /// </summary>
        /// <param name="aggregatedAt">aggregatedAt.</param>
        /// <param name="backgroundAggregationIsDisabled">backgroundAggregationIsDisabled.</param>
        /// <param name="connectionStatus">connectionStatus.</param>
        /// <param name="connectionStatusMessage">connectionStatusMessage.</param>
        /// <param name="error">error.</param>
        /// <param name="guid">guid.</param>
        /// <param name="id">id.</param>
        /// <param name="institutionCode">institutionCode.</param>
        /// <param name="institutionGuid">institutionGuid.</param>
        /// <param name="isBeingAggregated">isBeingAggregated.</param>
        /// <param name="isManagedByUser">isManagedByUser.</param>
        /// <param name="isManual">isManual.</param>
        /// <param name="isOauth">isOauth.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="mostRecentJobDetailCode">mostRecentJobDetailCode.</param>
        /// <param name="mostRecentJobDetailText">mostRecentJobDetailText.</param>
        /// <param name="mostRecentJobGuid">mostRecentJobGuid.</param>
        /// <param name="name">name.</param>
        /// <param name="needsUpdatedCredentials">needsUpdatedCredentials.</param>
        /// <param name="oauthWindowUri">oauthWindowUri.</param>
        /// <param name="successfullyAggregatedAt">successfullyAggregatedAt.</param>
        /// <param name="useCases">The use case associated with the member. Valid values are &#x60;PFM&#x60; and/or &#x60;MONEY_MOVEMENT&#x60;. Only set this if you&#39;ve met with MX and have opted in to using this field..</param>
        /// <param name="userGuid">userGuid.</param>
        /// <param name="userId">userId.</param>
        public MemberResponse(string aggregatedAt = default(string), bool backgroundAggregationIsDisabled = default(bool), string connectionStatus = default(string), string connectionStatusMessage = default(string), string error = default(string), string guid = default(string), string id = default(string), string institutionCode = default(string), string institutionGuid = default(string), bool? isBeingAggregated = default(bool?), bool? isManagedByUser = default(bool?), bool? isManual = default(bool?), bool? isOauth = default(bool?), string metadata = default(string), int? mostRecentJobDetailCode = default(int?), bool? mostRecentJobDetailText = default(bool?), bool? mostRecentJobGuid = default(bool?), string name = default(string), bool? needsUpdatedCredentials = default(bool?), string oauthWindowUri = default(string), string successfullyAggregatedAt = default(string), List<UseCasesEnum> useCases = default(List<UseCasesEnum>), string userGuid = default(string), string userId = default(string))
        {
            this.AggregatedAt = aggregatedAt;
            this.BackgroundAggregationIsDisabled = backgroundAggregationIsDisabled;
            this.ConnectionStatus = connectionStatus;
            this.ConnectionStatusMessage = connectionStatusMessage;
            this.Error = error;
            this.Guid = guid;
            this.Id = id;
            this.InstitutionCode = institutionCode;
            this.InstitutionGuid = institutionGuid;
            this.IsBeingAggregated = isBeingAggregated;
            this.IsManagedByUser = isManagedByUser;
            this.IsManual = isManual;
            this.IsOauth = isOauth;
            this.Metadata = metadata;
            this.MostRecentJobDetailCode = mostRecentJobDetailCode;
            this.MostRecentJobDetailText = mostRecentJobDetailText;
            this.MostRecentJobGuid = mostRecentJobGuid;
            this.Name = name;
            this.NeedsUpdatedCredentials = needsUpdatedCredentials;
            this.OauthWindowUri = oauthWindowUri;
            this.SuccessfullyAggregatedAt = successfullyAggregatedAt;
            this.UseCases = useCases;
            this.UserGuid = userGuid;
            this.UserId = userId;
        }

        /// <summary>
        /// Gets or Sets AggregatedAt
        /// </summary>
        /// <example>2016-10-13T18:07:57.000Z</example>
        [DataMember(Name = "aggregated_at", EmitDefaultValue = true)]
        public string AggregatedAt { get; set; }

        /// <summary>
        /// Gets or Sets BackgroundAggregationIsDisabled
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "background_aggregation_is_disabled", EmitDefaultValue = true)]
        public bool BackgroundAggregationIsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionStatus
        /// </summary>
        /// <example>CONNECTED</example>
        [DataMember(Name = "connection_status", EmitDefaultValue = true)]
        public string ConnectionStatus { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionStatusMessage
        /// </summary>
        /// <example>Connected to MX Bank</example>
        [DataMember(Name = "connection_status_message", EmitDefaultValue = true)]
        public string ConnectionStatusMessage { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        /// <example>{\&quot;error_type\&quot;: \&quot;MEMBER\&quot;, \&quot;error_code\&quot;: 1000, \&quot;error_message\&quot;: \&quot;This Member has no eligible checking, savings, or money market accounts.\&quot;, \&quot;user_message\&quot;: \&quot;We could not find any accounts eligible for transfers. Please link a checking or savings account.\&quot;, \&quot;locale\&quot;: \&quot;en\&quot;}</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        /// <example>MBR-7c6f361b-e582-15b6-60c0-358f12466b4b</example>
        [DataMember(Name = "guid", EmitDefaultValue = true)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>unique_id</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionCode
        /// </summary>
        /// <example>mxbank</example>
        [DataMember(Name = "institution_code", EmitDefaultValue = true)]
        public string InstitutionCode { get; set; }

        /// <summary>
        /// Gets or Sets InstitutionGuid
        /// </summary>
        /// <example>INS-12345678-90ab-cdef-1234-567890abcdef</example>
        [DataMember(Name = "institution_guid", EmitDefaultValue = false)]
        public string InstitutionGuid { get; set; }

        /// <summary>
        /// Gets or Sets IsBeingAggregated
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "is_being_aggregated", EmitDefaultValue = true)]
        public bool? IsBeingAggregated { get; set; }

        /// <summary>
        /// Gets or Sets IsManagedByUser
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "is_managed_by_user", EmitDefaultValue = true)]
        public bool? IsManagedByUser { get; set; }

        /// <summary>
        /// Gets or Sets IsManual
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "is_manual", EmitDefaultValue = true)]
        public bool? IsManual { get; set; }

        /// <summary>
        /// Gets or Sets IsOauth
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "is_oauth", EmitDefaultValue = true)]
        public bool? IsOauth { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        /// <example>\&quot;credentials_last_refreshed_at\&quot;: \&quot;2015-10-15\</example>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets MostRecentJobDetailCode
        /// </summary>
        [DataMember(Name = "most_recent_job_detail_code", EmitDefaultValue = true)]
        public int? MostRecentJobDetailCode { get; set; }

        /// <summary>
        /// Gets or Sets MostRecentJobDetailText
        /// </summary>
        [DataMember(Name = "most_recent_job_detail_text", EmitDefaultValue = true)]
        public bool? MostRecentJobDetailText { get; set; }

        /// <summary>
        /// Gets or Sets MostRecentJobGuid
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "most_recent_job_guid", EmitDefaultValue = true)]
        public bool? MostRecentJobGuid { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>MX Bank</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets NeedsUpdatedCredentials
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "needs_updated_credentials", EmitDefaultValue = true)]
        public bool? NeedsUpdatedCredentials { get; set; }

        /// <summary>
        /// Gets or Sets OauthWindowUri
        /// </summary>
        /// <example>https://mxbank.mx.com/oauth/authorize?client_id&#x3D;b8OikQ4Ep3NuSUrQ13DdvFuwpNx-qqoAsJDVAQCyLkQ&amp;redirect_uri&#x3D;https%3A%2F%2Fint-app.moneydesktop.com%2Foauth%2Fredirect_from&amp;response_type&#x3D;code&amp;scope&#x3D;openid&amp;state&#x3D;d745bd4ee6f0f9c184757f574bcc2df2</example>
        [DataMember(Name = "oauth_window_uri", EmitDefaultValue = true)]
        public string OauthWindowUri { get; set; }

        /// <summary>
        /// Gets or Sets SuccessfullyAggregatedAt
        /// </summary>
        /// <example>2016-10-13T17:57:38.000Z</example>
        [DataMember(Name = "successfully_aggregated_at", EmitDefaultValue = true)]
        public string SuccessfullyAggregatedAt { get; set; }

        /// <summary>
        /// The use case associated with the member. Valid values are &#x60;PFM&#x60; and/or &#x60;MONEY_MOVEMENT&#x60;. Only set this if you&#39;ve met with MX and have opted in to using this field.
        /// </summary>
        /// <value>The use case associated with the member. Valid values are &#x60;PFM&#x60; and/or &#x60;MONEY_MOVEMENT&#x60;. Only set this if you&#39;ve met with MX and have opted in to using this field.</value>
        /// <example>[&quot;PFM&quot;]</example>
        [DataMember(Name = "use_cases", EmitDefaultValue = false)]
        public List<MemberResponse.UseCasesEnum> UseCases { get; set; }

        /// <summary>
        /// Gets or Sets UserGuid
        /// </summary>
        /// <example>USR-fa7537f3-48aa-a683-a02a-b18940482f54</example>
        [DataMember(Name = "user_guid", EmitDefaultValue = true)]
        public string UserGuid { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        /// <example>user123</example>
        [DataMember(Name = "user_id", EmitDefaultValue = true)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MemberResponse {\n");
            sb.Append("  AggregatedAt: ").Append(AggregatedAt).Append("\n");
            sb.Append("  BackgroundAggregationIsDisabled: ").Append(BackgroundAggregationIsDisabled).Append("\n");
            sb.Append("  ConnectionStatus: ").Append(ConnectionStatus).Append("\n");
            sb.Append("  ConnectionStatusMessage: ").Append(ConnectionStatusMessage).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InstitutionCode: ").Append(InstitutionCode).Append("\n");
            sb.Append("  InstitutionGuid: ").Append(InstitutionGuid).Append("\n");
            sb.Append("  IsBeingAggregated: ").Append(IsBeingAggregated).Append("\n");
            sb.Append("  IsManagedByUser: ").Append(IsManagedByUser).Append("\n");
            sb.Append("  IsManual: ").Append(IsManual).Append("\n");
            sb.Append("  IsOauth: ").Append(IsOauth).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MostRecentJobDetailCode: ").Append(MostRecentJobDetailCode).Append("\n");
            sb.Append("  MostRecentJobDetailText: ").Append(MostRecentJobDetailText).Append("\n");
            sb.Append("  MostRecentJobGuid: ").Append(MostRecentJobGuid).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NeedsUpdatedCredentials: ").Append(NeedsUpdatedCredentials).Append("\n");
            sb.Append("  OauthWindowUri: ").Append(OauthWindowUri).Append("\n");
            sb.Append("  SuccessfullyAggregatedAt: ").Append(SuccessfullyAggregatedAt).Append("\n");
            sb.Append("  UseCases: ").Append(UseCases).Append("\n");
            sb.Append("  UserGuid: ").Append(UserGuid).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as MemberResponse);
        }

        /// <summary>
        /// Returns true if MemberResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AggregatedAt == input.AggregatedAt ||
                    (this.AggregatedAt != null &&
                    this.AggregatedAt.Equals(input.AggregatedAt))
                ) && 
                (
                    this.BackgroundAggregationIsDisabled == input.BackgroundAggregationIsDisabled ||
                    this.BackgroundAggregationIsDisabled.Equals(input.BackgroundAggregationIsDisabled)
                ) && 
                (
                    this.ConnectionStatus == input.ConnectionStatus ||
                    (this.ConnectionStatus != null &&
                    this.ConnectionStatus.Equals(input.ConnectionStatus))
                ) && 
                (
                    this.ConnectionStatusMessage == input.ConnectionStatusMessage ||
                    (this.ConnectionStatusMessage != null &&
                    this.ConnectionStatusMessage.Equals(input.ConnectionStatusMessage))
                ) && 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
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
                    this.InstitutionGuid == input.InstitutionGuid ||
                    (this.InstitutionGuid != null &&
                    this.InstitutionGuid.Equals(input.InstitutionGuid))
                ) && 
                (
                    this.IsBeingAggregated == input.IsBeingAggregated ||
                    (this.IsBeingAggregated != null &&
                    this.IsBeingAggregated.Equals(input.IsBeingAggregated))
                ) && 
                (
                    this.IsManagedByUser == input.IsManagedByUser ||
                    (this.IsManagedByUser != null &&
                    this.IsManagedByUser.Equals(input.IsManagedByUser))
                ) && 
                (
                    this.IsManual == input.IsManual ||
                    (this.IsManual != null &&
                    this.IsManual.Equals(input.IsManual))
                ) && 
                (
                    this.IsOauth == input.IsOauth ||
                    (this.IsOauth != null &&
                    this.IsOauth.Equals(input.IsOauth))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.MostRecentJobDetailCode == input.MostRecentJobDetailCode ||
                    (this.MostRecentJobDetailCode != null &&
                    this.MostRecentJobDetailCode.Equals(input.MostRecentJobDetailCode))
                ) && 
                (
                    this.MostRecentJobDetailText == input.MostRecentJobDetailText ||
                    (this.MostRecentJobDetailText != null &&
                    this.MostRecentJobDetailText.Equals(input.MostRecentJobDetailText))
                ) && 
                (
                    this.MostRecentJobGuid == input.MostRecentJobGuid ||
                    (this.MostRecentJobGuid != null &&
                    this.MostRecentJobGuid.Equals(input.MostRecentJobGuid))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NeedsUpdatedCredentials == input.NeedsUpdatedCredentials ||
                    (this.NeedsUpdatedCredentials != null &&
                    this.NeedsUpdatedCredentials.Equals(input.NeedsUpdatedCredentials))
                ) && 
                (
                    this.OauthWindowUri == input.OauthWindowUri ||
                    (this.OauthWindowUri != null &&
                    this.OauthWindowUri.Equals(input.OauthWindowUri))
                ) && 
                (
                    this.SuccessfullyAggregatedAt == input.SuccessfullyAggregatedAt ||
                    (this.SuccessfullyAggregatedAt != null &&
                    this.SuccessfullyAggregatedAt.Equals(input.SuccessfullyAggregatedAt))
                ) && 
                (
                    this.UseCases == input.UseCases ||
                    this.UseCases != null &&
                    input.UseCases != null &&
                    this.UseCases.SequenceEqual(input.UseCases)
                ) && 
                (
                    this.UserGuid == input.UserGuid ||
                    (this.UserGuid != null &&
                    this.UserGuid.Equals(input.UserGuid))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.AggregatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.AggregatedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BackgroundAggregationIsDisabled.GetHashCode();
                if (this.ConnectionStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionStatus.GetHashCode();
                }
                if (this.ConnectionStatusMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectionStatusMessage.GetHashCode();
                }
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.InstitutionCode != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionCode.GetHashCode();
                }
                if (this.InstitutionGuid != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionGuid.GetHashCode();
                }
                if (this.IsBeingAggregated != null)
                {
                    hashCode = (hashCode * 59) + this.IsBeingAggregated.GetHashCode();
                }
                if (this.IsManagedByUser != null)
                {
                    hashCode = (hashCode * 59) + this.IsManagedByUser.GetHashCode();
                }
                if (this.IsManual != null)
                {
                    hashCode = (hashCode * 59) + this.IsManual.GetHashCode();
                }
                if (this.IsOauth != null)
                {
                    hashCode = (hashCode * 59) + this.IsOauth.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.MostRecentJobDetailCode != null)
                {
                    hashCode = (hashCode * 59) + this.MostRecentJobDetailCode.GetHashCode();
                }
                if (this.MostRecentJobDetailText != null)
                {
                    hashCode = (hashCode * 59) + this.MostRecentJobDetailText.GetHashCode();
                }
                if (this.MostRecentJobGuid != null)
                {
                    hashCode = (hashCode * 59) + this.MostRecentJobGuid.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.NeedsUpdatedCredentials != null)
                {
                    hashCode = (hashCode * 59) + this.NeedsUpdatedCredentials.GetHashCode();
                }
                if (this.OauthWindowUri != null)
                {
                    hashCode = (hashCode * 59) + this.OauthWindowUri.GetHashCode();
                }
                if (this.SuccessfullyAggregatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessfullyAggregatedAt.GetHashCode();
                }
                if (this.UseCases != null)
                {
                    hashCode = (hashCode * 59) + this.UseCases.GetHashCode();
                }
                if (this.UserGuid != null)
                {
                    hashCode = (hashCode * 59) + this.UserGuid.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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

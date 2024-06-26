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
    /// WidgetRequest
    /// </summary>
    [DataContract(Name = "WidgetRequest")]
    public partial class WidgetRequest : IEquatable<WidgetRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WidgetRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WidgetRequest" /> class.
        /// </summary>
        /// <param name="clientRedirectUrl">clientRedirectUrl.</param>
        /// <param name="colorScheme">colorScheme.</param>
        /// <param name="currentInstitutionCode">currentInstitutionCode.</param>
        /// <param name="currentInstitutionGuid">currentInstitutionGuid.</param>
        /// <param name="currentMemberGuid">currentMemberGuid.</param>
        /// <param name="disableBackgroundAgg">disableBackgroundAgg.</param>
        /// <param name="disableInstitutionSearch">disableInstitutionSearch.</param>
        /// <param name="includeIdentity">includeIdentity.</param>
        /// <param name="includeTransactions">includeTransactions.</param>
        /// <param name="insightGuid">insightGuid.</param>
        /// <param name="isMobileWebview">isMobileWebview.</param>
        /// <param name="microwidgetInstanceId">microwidgetInstanceId.</param>
        /// <param name="mode">mode.</param>
        /// <param name="oauthReferralSource">oauthReferralSource.</param>
        /// <param name="uiMessageVersion">uiMessageVersion.</param>
        /// <param name="uiMessageWebviewUrlScheme">uiMessageWebviewUrlScheme.</param>
        /// <param name="updateCredentials">updateCredentials.</param>
        /// <param name="widgetType">widgetType (required).</param>
        public WidgetRequest(string clientRedirectUrl = default(string), string colorScheme = default(string), string currentInstitutionCode = default(string), string currentInstitutionGuid = default(string), string currentMemberGuid = default(string), bool disableBackgroundAgg = default(bool), bool disableInstitutionSearch = default(bool), bool includeIdentity = default(bool), bool includeTransactions = default(bool), string insightGuid = default(string), bool isMobileWebview = default(bool), string microwidgetInstanceId = default(string), string mode = default(string), string oauthReferralSource = default(string), int uiMessageVersion = default(int), string uiMessageWebviewUrlScheme = default(string), bool updateCredentials = default(bool), string widgetType = default(string))
        {
            // to ensure "widgetType" is required (not null)
            if (widgetType == null)
            {
                throw new ArgumentNullException("widgetType is a required property for WidgetRequest and cannot be null");
            }
            this.WidgetType = widgetType;
            this.ClientRedirectUrl = clientRedirectUrl;
            this.ColorScheme = colorScheme;
            this.CurrentInstitutionCode = currentInstitutionCode;
            this.CurrentInstitutionGuid = currentInstitutionGuid;
            this.CurrentMemberGuid = currentMemberGuid;
            this.DisableBackgroundAgg = disableBackgroundAgg;
            this.DisableInstitutionSearch = disableInstitutionSearch;
            this.IncludeIdentity = includeIdentity;
            this.IncludeTransactions = includeTransactions;
            this.InsightGuid = insightGuid;
            this.IsMobileWebview = isMobileWebview;
            this.MicrowidgetInstanceId = microwidgetInstanceId;
            this.Mode = mode;
            this.OauthReferralSource = oauthReferralSource;
            this.UiMessageVersion = uiMessageVersion;
            this.UiMessageWebviewUrlScheme = uiMessageWebviewUrlScheme;
            this.UpdateCredentials = updateCredentials;
        }

        /// <summary>
        /// Gets or Sets ClientRedirectUrl
        /// </summary>
        /// <example>https://mx.com</example>
        [DataMember(Name = "client_redirect_url", EmitDefaultValue = false)]
        public string ClientRedirectUrl { get; set; }

        /// <summary>
        /// Gets or Sets ColorScheme
        /// </summary>
        /// <example>light</example>
        [DataMember(Name = "color_scheme", EmitDefaultValue = false)]
        public string ColorScheme { get; set; }

        /// <summary>
        /// Gets or Sets CurrentInstitutionCode
        /// </summary>
        /// <example>chase</example>
        [DataMember(Name = "current_institution_code", EmitDefaultValue = false)]
        public string CurrentInstitutionCode { get; set; }

        /// <summary>
        /// Gets or Sets CurrentInstitutionGuid
        /// </summary>
        /// <example>INS-f1a3285d-e855-b61f-6aa7-8ae575c0e0e9</example>
        [DataMember(Name = "current_institution_guid", EmitDefaultValue = false)]
        public string CurrentInstitutionGuid { get; set; }

        /// <summary>
        /// Gets or Sets CurrentMemberGuid
        /// </summary>
        /// <example>MBR-7c6f361b-e582-15b6-60c0-358f12466b4b</example>
        [DataMember(Name = "current_member_guid", EmitDefaultValue = false)]
        public string CurrentMemberGuid { get; set; }

        /// <summary>
        /// Gets or Sets DisableBackgroundAgg
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "disable_background_agg", EmitDefaultValue = true)]
        public bool DisableBackgroundAgg { get; set; }

        /// <summary>
        /// Gets or Sets DisableInstitutionSearch
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "disable_institution_search", EmitDefaultValue = true)]
        public bool DisableInstitutionSearch { get; set; }

        /// <summary>
        /// Gets or Sets IncludeIdentity
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "include_identity", EmitDefaultValue = true)]
        public bool IncludeIdentity { get; set; }

        /// <summary>
        /// Gets or Sets IncludeTransactions
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "include_transactions", EmitDefaultValue = true)]
        public bool IncludeTransactions { get; set; }

        /// <summary>
        /// Gets or Sets InsightGuid
        /// </summary>
        /// <example>BET-123</example>
        [DataMember(Name = "insight_guid", EmitDefaultValue = false)]
        public string InsightGuid { get; set; }

        /// <summary>
        /// Gets or Sets IsMobileWebview
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "is_mobile_webview", EmitDefaultValue = true)]
        public bool IsMobileWebview { get; set; }

        /// <summary>
        /// Gets or Sets MicrowidgetInstanceId
        /// </summary>
        /// <example>accounts_page</example>
        [DataMember(Name = "microwidget_instance_id", EmitDefaultValue = false)]
        public string MicrowidgetInstanceId { get; set; }

        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        /// <example>aggregation</example>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or Sets OauthReferralSource
        /// </summary>
        /// <example>BROWSER</example>
        [DataMember(Name = "oauth_referral_source", EmitDefaultValue = false)]
        public string OauthReferralSource { get; set; }

        /// <summary>
        /// Gets or Sets UiMessageVersion
        /// </summary>
        /// <example>4</example>
        [DataMember(Name = "ui_message_version", EmitDefaultValue = false)]
        public int UiMessageVersion { get; set; }

        /// <summary>
        /// Gets or Sets UiMessageWebviewUrlScheme
        /// </summary>
        /// <example>mx</example>
        [DataMember(Name = "ui_message_webview_url_scheme", EmitDefaultValue = false)]
        public string UiMessageWebviewUrlScheme { get; set; }

        /// <summary>
        /// Gets or Sets UpdateCredentials
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "update_credentials", EmitDefaultValue = true)]
        public bool UpdateCredentials { get; set; }

        /// <summary>
        /// Gets or Sets WidgetType
        /// </summary>
        /// <example>connect_widget</example>
        [DataMember(Name = "widget_type", IsRequired = true, EmitDefaultValue = true)]
        public string WidgetType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WidgetRequest {\n");
            sb.Append("  ClientRedirectUrl: ").Append(ClientRedirectUrl).Append("\n");
            sb.Append("  ColorScheme: ").Append(ColorScheme).Append("\n");
            sb.Append("  CurrentInstitutionCode: ").Append(CurrentInstitutionCode).Append("\n");
            sb.Append("  CurrentInstitutionGuid: ").Append(CurrentInstitutionGuid).Append("\n");
            sb.Append("  CurrentMemberGuid: ").Append(CurrentMemberGuid).Append("\n");
            sb.Append("  DisableBackgroundAgg: ").Append(DisableBackgroundAgg).Append("\n");
            sb.Append("  DisableInstitutionSearch: ").Append(DisableInstitutionSearch).Append("\n");
            sb.Append("  IncludeIdentity: ").Append(IncludeIdentity).Append("\n");
            sb.Append("  IncludeTransactions: ").Append(IncludeTransactions).Append("\n");
            sb.Append("  InsightGuid: ").Append(InsightGuid).Append("\n");
            sb.Append("  IsMobileWebview: ").Append(IsMobileWebview).Append("\n");
            sb.Append("  MicrowidgetInstanceId: ").Append(MicrowidgetInstanceId).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  OauthReferralSource: ").Append(OauthReferralSource).Append("\n");
            sb.Append("  UiMessageVersion: ").Append(UiMessageVersion).Append("\n");
            sb.Append("  UiMessageWebviewUrlScheme: ").Append(UiMessageWebviewUrlScheme).Append("\n");
            sb.Append("  UpdateCredentials: ").Append(UpdateCredentials).Append("\n");
            sb.Append("  WidgetType: ").Append(WidgetType).Append("\n");
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
            return this.Equals(input as WidgetRequest);
        }

        /// <summary>
        /// Returns true if WidgetRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of WidgetRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WidgetRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientRedirectUrl == input.ClientRedirectUrl ||
                    (this.ClientRedirectUrl != null &&
                    this.ClientRedirectUrl.Equals(input.ClientRedirectUrl))
                ) && 
                (
                    this.ColorScheme == input.ColorScheme ||
                    (this.ColorScheme != null &&
                    this.ColorScheme.Equals(input.ColorScheme))
                ) && 
                (
                    this.CurrentInstitutionCode == input.CurrentInstitutionCode ||
                    (this.CurrentInstitutionCode != null &&
                    this.CurrentInstitutionCode.Equals(input.CurrentInstitutionCode))
                ) && 
                (
                    this.CurrentInstitutionGuid == input.CurrentInstitutionGuid ||
                    (this.CurrentInstitutionGuid != null &&
                    this.CurrentInstitutionGuid.Equals(input.CurrentInstitutionGuid))
                ) && 
                (
                    this.CurrentMemberGuid == input.CurrentMemberGuid ||
                    (this.CurrentMemberGuid != null &&
                    this.CurrentMemberGuid.Equals(input.CurrentMemberGuid))
                ) && 
                (
                    this.DisableBackgroundAgg == input.DisableBackgroundAgg ||
                    this.DisableBackgroundAgg.Equals(input.DisableBackgroundAgg)
                ) && 
                (
                    this.DisableInstitutionSearch == input.DisableInstitutionSearch ||
                    this.DisableInstitutionSearch.Equals(input.DisableInstitutionSearch)
                ) && 
                (
                    this.IncludeIdentity == input.IncludeIdentity ||
                    this.IncludeIdentity.Equals(input.IncludeIdentity)
                ) && 
                (
                    this.IncludeTransactions == input.IncludeTransactions ||
                    this.IncludeTransactions.Equals(input.IncludeTransactions)
                ) && 
                (
                    this.InsightGuid == input.InsightGuid ||
                    (this.InsightGuid != null &&
                    this.InsightGuid.Equals(input.InsightGuid))
                ) && 
                (
                    this.IsMobileWebview == input.IsMobileWebview ||
                    this.IsMobileWebview.Equals(input.IsMobileWebview)
                ) && 
                (
                    this.MicrowidgetInstanceId == input.MicrowidgetInstanceId ||
                    (this.MicrowidgetInstanceId != null &&
                    this.MicrowidgetInstanceId.Equals(input.MicrowidgetInstanceId))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.OauthReferralSource == input.OauthReferralSource ||
                    (this.OauthReferralSource != null &&
                    this.OauthReferralSource.Equals(input.OauthReferralSource))
                ) && 
                (
                    this.UiMessageVersion == input.UiMessageVersion ||
                    this.UiMessageVersion.Equals(input.UiMessageVersion)
                ) && 
                (
                    this.UiMessageWebviewUrlScheme == input.UiMessageWebviewUrlScheme ||
                    (this.UiMessageWebviewUrlScheme != null &&
                    this.UiMessageWebviewUrlScheme.Equals(input.UiMessageWebviewUrlScheme))
                ) && 
                (
                    this.UpdateCredentials == input.UpdateCredentials ||
                    this.UpdateCredentials.Equals(input.UpdateCredentials)
                ) && 
                (
                    this.WidgetType == input.WidgetType ||
                    (this.WidgetType != null &&
                    this.WidgetType.Equals(input.WidgetType))
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
                if (this.ClientRedirectUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ClientRedirectUrl.GetHashCode();
                }
                if (this.ColorScheme != null)
                {
                    hashCode = (hashCode * 59) + this.ColorScheme.GetHashCode();
                }
                if (this.CurrentInstitutionCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentInstitutionCode.GetHashCode();
                }
                if (this.CurrentInstitutionGuid != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentInstitutionGuid.GetHashCode();
                }
                if (this.CurrentMemberGuid != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentMemberGuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DisableBackgroundAgg.GetHashCode();
                hashCode = (hashCode * 59) + this.DisableInstitutionSearch.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeIdentity.GetHashCode();
                hashCode = (hashCode * 59) + this.IncludeTransactions.GetHashCode();
                if (this.InsightGuid != null)
                {
                    hashCode = (hashCode * 59) + this.InsightGuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsMobileWebview.GetHashCode();
                if (this.MicrowidgetInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.MicrowidgetInstanceId.GetHashCode();
                }
                if (this.Mode != null)
                {
                    hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                }
                if (this.OauthReferralSource != null)
                {
                    hashCode = (hashCode * 59) + this.OauthReferralSource.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UiMessageVersion.GetHashCode();
                if (this.UiMessageWebviewUrlScheme != null)
                {
                    hashCode = (hashCode * 59) + this.UiMessageWebviewUrlScheme.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.UpdateCredentials.GetHashCode();
                if (this.WidgetType != null)
                {
                    hashCode = (hashCode * 59) + this.WidgetType.GetHashCode();
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

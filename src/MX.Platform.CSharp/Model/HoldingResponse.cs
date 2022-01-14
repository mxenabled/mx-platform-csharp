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
    /// HoldingResponse
    /// </summary>
    [DataContract(Name = "HoldingResponse")]
    public partial class HoldingResponse : IEquatable<HoldingResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HoldingResponse" /> class.
        /// </summary>
        /// <param name="accountGuid">accountGuid.</param>
        /// <param name="costBasis">costBasis.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="cusip">cusip.</param>
        /// <param name="dailyChange">dailyChange.</param>
        /// <param name="description">description.</param>
        /// <param name="guid">guid.</param>
        /// <param name="holdingType">holdingType.</param>
        /// <param name="id">id.</param>
        /// <param name="marketValue">marketValue.</param>
        /// <param name="memberGuid">memberGuid.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="purchasePrice">purchasePrice.</param>
        /// <param name="shares">shares.</param>
        /// <param name="symbol">symbol.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="userGuid">userGuid.</param>
        public HoldingResponse(string accountGuid = default(string), decimal? costBasis = default(decimal?), string createdAt = default(string), string currencyCode = default(string), string cusip = default(string), decimal? dailyChange = default(decimal?), string description = default(string), string guid = default(string), string holdingType = default(string), string id = default(string), decimal? marketValue = default(decimal?), string memberGuid = default(string), string metadata = default(string), decimal? purchasePrice = default(decimal?), decimal? shares = default(decimal?), string symbol = default(string), string updatedAt = default(string), string userGuid = default(string))
        {
            this.AccountGuid = accountGuid;
            this.CostBasis = costBasis;
            this.CreatedAt = createdAt;
            this.CurrencyCode = currencyCode;
            this.Cusip = cusip;
            this.DailyChange = dailyChange;
            this.Description = description;
            this.Guid = guid;
            this.HoldingType = holdingType;
            this.Id = id;
            this.MarketValue = marketValue;
            this.MemberGuid = memberGuid;
            this.Metadata = metadata;
            this.PurchasePrice = purchasePrice;
            this.Shares = shares;
            this.Symbol = symbol;
            this.UpdatedAt = updatedAt;
            this.UserGuid = userGuid;
        }

        /// <summary>
        /// Gets or Sets AccountGuid
        /// </summary>
        [DataMember(Name = "account_guid", EmitDefaultValue = false)]
        public string AccountGuid { get; set; }

        /// <summary>
        /// Gets or Sets CostBasis
        /// </summary>
        [DataMember(Name = "cost_basis", EmitDefaultValue = true)]
        public decimal? CostBasis { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name = "currency_code", EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Cusip
        /// </summary>
        [DataMember(Name = "cusip", EmitDefaultValue = true)]
        public string Cusip { get; set; }

        /// <summary>
        /// Gets or Sets DailyChange
        /// </summary>
        [DataMember(Name = "daily_change", EmitDefaultValue = true)]
        public decimal? DailyChange { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name = "guid", EmitDefaultValue = false)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets HoldingType
        /// </summary>
        [DataMember(Name = "holding_type", EmitDefaultValue = true)]
        public string HoldingType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets MarketValue
        /// </summary>
        [DataMember(Name = "market_value", EmitDefaultValue = true)]
        public decimal? MarketValue { get; set; }

        /// <summary>
        /// Gets or Sets MemberGuid
        /// </summary>
        [DataMember(Name = "member_guid", EmitDefaultValue = false)]
        public string MemberGuid { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePrice
        /// </summary>
        [DataMember(Name = "purchase_price", EmitDefaultValue = true)]
        public decimal? PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets Shares
        /// </summary>
        [DataMember(Name = "shares", EmitDefaultValue = true)]
        public decimal? Shares { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UserGuid
        /// </summary>
        [DataMember(Name = "user_guid", EmitDefaultValue = false)]
        public string UserGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HoldingResponse {\n");
            sb.Append("  AccountGuid: ").Append(AccountGuid).Append("\n");
            sb.Append("  CostBasis: ").Append(CostBasis).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Cusip: ").Append(Cusip).Append("\n");
            sb.Append("  DailyChange: ").Append(DailyChange).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  HoldingType: ").Append(HoldingType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MarketValue: ").Append(MarketValue).Append("\n");
            sb.Append("  MemberGuid: ").Append(MemberGuid).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  Shares: ").Append(Shares).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as HoldingResponse);
        }

        /// <summary>
        /// Returns true if HoldingResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of HoldingResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HoldingResponse input)
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
                    this.CostBasis == input.CostBasis ||
                    (this.CostBasis != null &&
                    this.CostBasis.Equals(input.CostBasis))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Cusip == input.Cusip ||
                    (this.Cusip != null &&
                    this.Cusip.Equals(input.Cusip))
                ) && 
                (
                    this.DailyChange == input.DailyChange ||
                    (this.DailyChange != null &&
                    this.DailyChange.Equals(input.DailyChange))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.HoldingType == input.HoldingType ||
                    (this.HoldingType != null &&
                    this.HoldingType.Equals(input.HoldingType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MarketValue == input.MarketValue ||
                    (this.MarketValue != null &&
                    this.MarketValue.Equals(input.MarketValue))
                ) && 
                (
                    this.MemberGuid == input.MemberGuid ||
                    (this.MemberGuid != null &&
                    this.MemberGuid.Equals(input.MemberGuid))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.Shares == input.Shares ||
                    (this.Shares != null &&
                    this.Shares.Equals(input.Shares))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.CostBasis != null)
                {
                    hashCode = (hashCode * 59) + this.CostBasis.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.Cusip != null)
                {
                    hashCode = (hashCode * 59) + this.Cusip.GetHashCode();
                }
                if (this.DailyChange != null)
                {
                    hashCode = (hashCode * 59) + this.DailyChange.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.HoldingType != null)
                {
                    hashCode = (hashCode * 59) + this.HoldingType.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.MarketValue != null)
                {
                    hashCode = (hashCode * 59) + this.MarketValue.GetHashCode();
                }
                if (this.MemberGuid != null)
                {
                    hashCode = (hashCode * 59) + this.MemberGuid.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.PurchasePrice != null)
                {
                    hashCode = (hashCode * 59) + this.PurchasePrice.GetHashCode();
                }
                if (this.Shares != null)
                {
                    hashCode = (hashCode * 59) + this.Shares.GetHashCode();
                }
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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

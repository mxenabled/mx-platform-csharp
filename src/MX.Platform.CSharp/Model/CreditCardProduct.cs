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
    /// CreditCardProduct
    /// </summary>
    [DataContract(Name = "CreditCardProduct")]
    public partial class CreditCardProduct : IEquatable<CreditCardProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardProduct" /> class.
        /// </summary>
        /// <param name="annualFee">annualFee.</param>
        /// <param name="durationOfIntroductoryRateOnBalanceTransfer">durationOfIntroductoryRateOnBalanceTransfer.</param>
        /// <param name="durationOfIntroductoryRateOnPurchases">durationOfIntroductoryRateOnPurchases.</param>
        /// <param name="guid">guid.</param>
        /// <param name="hasCashbackRewards">hasCashbackRewards.</param>
        /// <param name="hasOtherRewards">hasOtherRewards.</param>
        /// <param name="hasTravelRewards">hasTravelRewards.</param>
        /// <param name="hasZeroIntroductoryAnnualFee">hasZeroIntroductoryAnnualFee.</param>
        /// <param name="hasZeroPercentIntroductoryRate">hasZeroPercentIntroductoryRate.</param>
        /// <param name="hasZeroPercentIntroductoryRateOnBalanceTransfer">hasZeroPercentIntroductoryRateOnBalanceTransfer.</param>
        /// <param name="financialInstitution">financialInstitution.</param>
        /// <param name="isAcceptingApplications">isAcceptingApplications.</param>
        /// <param name="isSmallBusinessCard">isSmallBusinessCard.</param>
        /// <param name="name">name.</param>
        public CreditCardProduct(Object annualFee = default(Object), Object durationOfIntroductoryRateOnBalanceTransfer = default(Object), Object durationOfIntroductoryRateOnPurchases = default(Object), Object guid = default(Object), bool hasCashbackRewards = default(bool), bool hasOtherRewards = default(bool), bool hasTravelRewards = default(bool), bool hasZeroIntroductoryAnnualFee = default(bool), bool hasZeroPercentIntroductoryRate = default(bool), bool hasZeroPercentIntroductoryRateOnBalanceTransfer = default(bool), bool financialInstitution = default(bool), bool isAcceptingApplications = default(bool), bool isSmallBusinessCard = default(bool), string name = default(string))
        {
            this.AnnualFee = annualFee;
            this.DurationOfIntroductoryRateOnBalanceTransfer = durationOfIntroductoryRateOnBalanceTransfer;
            this.DurationOfIntroductoryRateOnPurchases = durationOfIntroductoryRateOnPurchases;
            this.Guid = guid;
            this.HasCashbackRewards = hasCashbackRewards;
            this.HasOtherRewards = hasOtherRewards;
            this.HasTravelRewards = hasTravelRewards;
            this.HasZeroIntroductoryAnnualFee = hasZeroIntroductoryAnnualFee;
            this.HasZeroPercentIntroductoryRate = hasZeroPercentIntroductoryRate;
            this.HasZeroPercentIntroductoryRateOnBalanceTransfer = hasZeroPercentIntroductoryRateOnBalanceTransfer;
            this.FinancialInstitution = financialInstitution;
            this.IsAcceptingApplications = isAcceptingApplications;
            this.IsSmallBusinessCard = isSmallBusinessCard;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets AnnualFee
        /// </summary>
        /// <example>45.0</example>
        [DataMember(Name = "annual_fee", EmitDefaultValue = true)]
        public Object AnnualFee { get; set; }

        /// <summary>
        /// Gets or Sets DurationOfIntroductoryRateOnBalanceTransfer
        /// </summary>
        [DataMember(Name = "duration_of_introductory_rate_on_balance_transfer", EmitDefaultValue = true)]
        public Object DurationOfIntroductoryRateOnBalanceTransfer { get; set; }

        /// <summary>
        /// Gets or Sets DurationOfIntroductoryRateOnPurchases
        /// </summary>
        [DataMember(Name = "duration_of_introductory_rate_on_purchases", EmitDefaultValue = true)]
        public Object DurationOfIntroductoryRateOnPurchases { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        /// <example>CCA-b5bcd822-6d01-4e23-b8d6-846a225e714a</example>
        [DataMember(Name = "guid", EmitDefaultValue = true)]
        public Object Guid { get; set; }

        /// <summary>
        /// Gets or Sets HasCashbackRewards
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "has_cashback_rewards", EmitDefaultValue = true)]
        public bool HasCashbackRewards { get; set; }

        /// <summary>
        /// Gets or Sets HasOtherRewards
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "has_other_rewards", EmitDefaultValue = true)]
        public bool HasOtherRewards { get; set; }

        /// <summary>
        /// Gets or Sets HasTravelRewards
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "has_travel_rewards", EmitDefaultValue = true)]
        public bool HasTravelRewards { get; set; }

        /// <summary>
        /// Gets or Sets HasZeroIntroductoryAnnualFee
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "has_zero_introductory_annual_fee", EmitDefaultValue = true)]
        public bool HasZeroIntroductoryAnnualFee { get; set; }

        /// <summary>
        /// Gets or Sets HasZeroPercentIntroductoryRate
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "has_zero_percent_introductory_rate", EmitDefaultValue = true)]
        public bool HasZeroPercentIntroductoryRate { get; set; }

        /// <summary>
        /// Gets or Sets HasZeroPercentIntroductoryRateOnBalanceTransfer
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "has_zero_percent_introductory_rate_on_balance_transfer", EmitDefaultValue = true)]
        public bool HasZeroPercentIntroductoryRateOnBalanceTransfer { get; set; }

        /// <summary>
        /// Gets or Sets FinancialInstitution
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "financial_institution", EmitDefaultValue = true)]
        public bool FinancialInstitution { get; set; }

        /// <summary>
        /// Gets or Sets IsAcceptingApplications
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "is_accepting_applications", EmitDefaultValue = true)]
        public bool IsAcceptingApplications { get; set; }

        /// <summary>
        /// Gets or Sets IsSmallBusinessCard
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "is_small_business_card", EmitDefaultValue = true)]
        public bool IsSmallBusinessCard { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Chase Credit Card</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditCardProduct {\n");
            sb.Append("  AnnualFee: ").Append(AnnualFee).Append("\n");
            sb.Append("  DurationOfIntroductoryRateOnBalanceTransfer: ").Append(DurationOfIntroductoryRateOnBalanceTransfer).Append("\n");
            sb.Append("  DurationOfIntroductoryRateOnPurchases: ").Append(DurationOfIntroductoryRateOnPurchases).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  HasCashbackRewards: ").Append(HasCashbackRewards).Append("\n");
            sb.Append("  HasOtherRewards: ").Append(HasOtherRewards).Append("\n");
            sb.Append("  HasTravelRewards: ").Append(HasTravelRewards).Append("\n");
            sb.Append("  HasZeroIntroductoryAnnualFee: ").Append(HasZeroIntroductoryAnnualFee).Append("\n");
            sb.Append("  HasZeroPercentIntroductoryRate: ").Append(HasZeroPercentIntroductoryRate).Append("\n");
            sb.Append("  HasZeroPercentIntroductoryRateOnBalanceTransfer: ").Append(HasZeroPercentIntroductoryRateOnBalanceTransfer).Append("\n");
            sb.Append("  FinancialInstitution: ").Append(FinancialInstitution).Append("\n");
            sb.Append("  IsAcceptingApplications: ").Append(IsAcceptingApplications).Append("\n");
            sb.Append("  IsSmallBusinessCard: ").Append(IsSmallBusinessCard).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as CreditCardProduct);
        }

        /// <summary>
        /// Returns true if CreditCardProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditCardProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditCardProduct input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AnnualFee == input.AnnualFee ||
                    (this.AnnualFee != null &&
                    this.AnnualFee.Equals(input.AnnualFee))
                ) && 
                (
                    this.DurationOfIntroductoryRateOnBalanceTransfer == input.DurationOfIntroductoryRateOnBalanceTransfer ||
                    (this.DurationOfIntroductoryRateOnBalanceTransfer != null &&
                    this.DurationOfIntroductoryRateOnBalanceTransfer.Equals(input.DurationOfIntroductoryRateOnBalanceTransfer))
                ) && 
                (
                    this.DurationOfIntroductoryRateOnPurchases == input.DurationOfIntroductoryRateOnPurchases ||
                    (this.DurationOfIntroductoryRateOnPurchases != null &&
                    this.DurationOfIntroductoryRateOnPurchases.Equals(input.DurationOfIntroductoryRateOnPurchases))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.HasCashbackRewards == input.HasCashbackRewards ||
                    this.HasCashbackRewards.Equals(input.HasCashbackRewards)
                ) && 
                (
                    this.HasOtherRewards == input.HasOtherRewards ||
                    this.HasOtherRewards.Equals(input.HasOtherRewards)
                ) && 
                (
                    this.HasTravelRewards == input.HasTravelRewards ||
                    this.HasTravelRewards.Equals(input.HasTravelRewards)
                ) && 
                (
                    this.HasZeroIntroductoryAnnualFee == input.HasZeroIntroductoryAnnualFee ||
                    this.HasZeroIntroductoryAnnualFee.Equals(input.HasZeroIntroductoryAnnualFee)
                ) && 
                (
                    this.HasZeroPercentIntroductoryRate == input.HasZeroPercentIntroductoryRate ||
                    this.HasZeroPercentIntroductoryRate.Equals(input.HasZeroPercentIntroductoryRate)
                ) && 
                (
                    this.HasZeroPercentIntroductoryRateOnBalanceTransfer == input.HasZeroPercentIntroductoryRateOnBalanceTransfer ||
                    this.HasZeroPercentIntroductoryRateOnBalanceTransfer.Equals(input.HasZeroPercentIntroductoryRateOnBalanceTransfer)
                ) && 
                (
                    this.FinancialInstitution == input.FinancialInstitution ||
                    this.FinancialInstitution.Equals(input.FinancialInstitution)
                ) && 
                (
                    this.IsAcceptingApplications == input.IsAcceptingApplications ||
                    this.IsAcceptingApplications.Equals(input.IsAcceptingApplications)
                ) && 
                (
                    this.IsSmallBusinessCard == input.IsSmallBusinessCard ||
                    this.IsSmallBusinessCard.Equals(input.IsSmallBusinessCard)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.AnnualFee != null)
                {
                    hashCode = (hashCode * 59) + this.AnnualFee.GetHashCode();
                }
                if (this.DurationOfIntroductoryRateOnBalanceTransfer != null)
                {
                    hashCode = (hashCode * 59) + this.DurationOfIntroductoryRateOnBalanceTransfer.GetHashCode();
                }
                if (this.DurationOfIntroductoryRateOnPurchases != null)
                {
                    hashCode = (hashCode * 59) + this.DurationOfIntroductoryRateOnPurchases.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasCashbackRewards.GetHashCode();
                hashCode = (hashCode * 59) + this.HasOtherRewards.GetHashCode();
                hashCode = (hashCode * 59) + this.HasTravelRewards.GetHashCode();
                hashCode = (hashCode * 59) + this.HasZeroIntroductoryAnnualFee.GetHashCode();
                hashCode = (hashCode * 59) + this.HasZeroPercentIntroductoryRate.GetHashCode();
                hashCode = (hashCode * 59) + this.HasZeroPercentIntroductoryRateOnBalanceTransfer.GetHashCode();
                hashCode = (hashCode * 59) + this.FinancialInstitution.GetHashCode();
                hashCode = (hashCode * 59) + this.IsAcceptingApplications.GetHashCode();
                hashCode = (hashCode * 59) + this.IsSmallBusinessCard.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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

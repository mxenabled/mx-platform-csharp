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
    /// SpendingPlanIterationItemCreateRequestBody
    /// </summary>
    [DataContract(Name = "SpendingPlanIterationItemCreateRequestBody")]
    public partial class SpendingPlanIterationItemCreateRequestBody : IEquatable<SpendingPlanIterationItemCreateRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingPlanIterationItemCreateRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SpendingPlanIterationItemCreateRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingPlanIterationItemCreateRequestBody" /> class.
        /// </summary>
        /// <param name="categoryGuid">categoryGuid.</param>
        /// <param name="itemType">itemType.</param>
        /// <param name="plannedAmount">plannedAmount (required).</param>
        /// <param name="scheduledPaymentGuid">scheduledPaymentGuid.</param>
        /// <param name="topLevelCategoryGuid">topLevelCategoryGuid.</param>
        public SpendingPlanIterationItemCreateRequestBody(string categoryGuid = default(string), decimal itemType = default(decimal), decimal plannedAmount = default(decimal), string scheduledPaymentGuid = default(string), string topLevelCategoryGuid = default(string))
        {
            this.PlannedAmount = plannedAmount;
            this.CategoryGuid = categoryGuid;
            this.ItemType = itemType;
            this.ScheduledPaymentGuid = scheduledPaymentGuid;
            this.TopLevelCategoryGuid = topLevelCategoryGuid;
        }

        /// <summary>
        /// Gets or Sets CategoryGuid
        /// </summary>
        /// <example>CAT-40faf068-abb4-405c-8f6a-e883ed541fff</example>
        [DataMember(Name = "category_guid", EmitDefaultValue = false)]
        public string CategoryGuid { get; set; }

        /// <summary>
        /// Gets or Sets ItemType
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "item_type", EmitDefaultValue = false)]
        public decimal ItemType { get; set; }

        /// <summary>
        /// Gets or Sets PlannedAmount
        /// </summary>
        /// <example>110</example>
        [DataMember(Name = "planned_amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal PlannedAmount { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledPaymentGuid
        /// </summary>
        /// <example>SCP-c731988a-712f-4f83-9b3b-0aa5b3d5208b</example>
        [DataMember(Name = "scheduled_payment_guid", EmitDefaultValue = false)]
        public string ScheduledPaymentGuid { get; set; }

        /// <summary>
        /// Gets or Sets TopLevelCategoryGuid
        /// </summary>
        /// <example>CAT-9588eaad-90a4-bb5c-66c8-1812503d0db8</example>
        [DataMember(Name = "top_level_category_guid", EmitDefaultValue = false)]
        public string TopLevelCategoryGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpendingPlanIterationItemCreateRequestBody {\n");
            sb.Append("  CategoryGuid: ").Append(CategoryGuid).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  PlannedAmount: ").Append(PlannedAmount).Append("\n");
            sb.Append("  ScheduledPaymentGuid: ").Append(ScheduledPaymentGuid).Append("\n");
            sb.Append("  TopLevelCategoryGuid: ").Append(TopLevelCategoryGuid).Append("\n");
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
            return this.Equals(input as SpendingPlanIterationItemCreateRequestBody);
        }

        /// <summary>
        /// Returns true if SpendingPlanIterationItemCreateRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of SpendingPlanIterationItemCreateRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpendingPlanIterationItemCreateRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CategoryGuid == input.CategoryGuid ||
                    (this.CategoryGuid != null &&
                    this.CategoryGuid.Equals(input.CategoryGuid))
                ) && 
                (
                    this.ItemType == input.ItemType ||
                    this.ItemType.Equals(input.ItemType)
                ) && 
                (
                    this.PlannedAmount == input.PlannedAmount ||
                    this.PlannedAmount.Equals(input.PlannedAmount)
                ) && 
                (
                    this.ScheduledPaymentGuid == input.ScheduledPaymentGuid ||
                    (this.ScheduledPaymentGuid != null &&
                    this.ScheduledPaymentGuid.Equals(input.ScheduledPaymentGuid))
                ) && 
                (
                    this.TopLevelCategoryGuid == input.TopLevelCategoryGuid ||
                    (this.TopLevelCategoryGuid != null &&
                    this.TopLevelCategoryGuid.Equals(input.TopLevelCategoryGuid))
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
                if (this.CategoryGuid != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryGuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ItemType.GetHashCode();
                hashCode = (hashCode * 59) + this.PlannedAmount.GetHashCode();
                if (this.ScheduledPaymentGuid != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledPaymentGuid.GetHashCode();
                }
                if (this.TopLevelCategoryGuid != null)
                {
                    hashCode = (hashCode * 59) + this.TopLevelCategoryGuid.GetHashCode();
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

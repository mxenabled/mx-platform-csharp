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
    /// SpendingPlanIterationItemResponse
    /// </summary>
    [DataContract(Name = "SpendingPlanIterationItemResponse")]
    public partial class SpendingPlanIterationItemResponse : IEquatable<SpendingPlanIterationItemResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingPlanIterationItemResponse" /> class.
        /// </summary>
        /// <param name="actualAmount">actualAmount.</param>
        /// <param name="categoryGuid">categoryGuid.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="guid">guid.</param>
        /// <param name="itemType">itemType.</param>
        /// <param name="plannedAmount">plannedAmount.</param>
        /// <param name="scheduledPaymentGuid">scheduledPaymentGuid.</param>
        /// <param name="spendingPlanIterationGuid">spendingPlanIterationGuid.</param>
        /// <param name="topLevelCategoryGuid">topLevelCategoryGuid.</param>
        /// <param name="transactionGuids">transactionGuids.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="userGuid">userGuid.</param>
        public SpendingPlanIterationItemResponse(decimal? actualAmount = default(decimal?), string categoryGuid = default(string), string createdAt = default(string), string guid = default(string), string itemType = default(string), decimal? plannedAmount = default(decimal?), string scheduledPaymentGuid = default(string), string spendingPlanIterationGuid = default(string), string topLevelCategoryGuid = default(string), List<string> transactionGuids = default(List<string>), string updatedAt = default(string), string userGuid = default(string))
        {
            this.ActualAmount = actualAmount;
            this.CategoryGuid = categoryGuid;
            this.CreatedAt = createdAt;
            this.Guid = guid;
            this.ItemType = itemType;
            this.PlannedAmount = plannedAmount;
            this.ScheduledPaymentGuid = scheduledPaymentGuid;
            this.SpendingPlanIterationGuid = spendingPlanIterationGuid;
            this.TopLevelCategoryGuid = topLevelCategoryGuid;
            this.TransactionGuids = transactionGuids;
            this.UpdatedAt = updatedAt;
            this.UserGuid = userGuid;
        }

        /// <summary>
        /// Gets or Sets ActualAmount
        /// </summary>
        [DataMember(Name = "actual_amount", EmitDefaultValue = true)]
        public decimal? ActualAmount { get; set; }

        /// <summary>
        /// Gets or Sets CategoryGuid
        /// </summary>
        [DataMember(Name = "category_guid", EmitDefaultValue = true)]
        public string CategoryGuid { get; set; }

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
        /// Gets or Sets ItemType
        /// </summary>
        [DataMember(Name = "item_type", EmitDefaultValue = true)]
        public string ItemType { get; set; }

        /// <summary>
        /// Gets or Sets PlannedAmount
        /// </summary>
        [DataMember(Name = "planned_amount", EmitDefaultValue = true)]
        public decimal? PlannedAmount { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledPaymentGuid
        /// </summary>
        [DataMember(Name = "scheduled_payment_guid", EmitDefaultValue = true)]
        public string ScheduledPaymentGuid { get; set; }

        /// <summary>
        /// Gets or Sets SpendingPlanIterationGuid
        /// </summary>
        [DataMember(Name = "spending_plan_iteration_guid", EmitDefaultValue = true)]
        public string SpendingPlanIterationGuid { get; set; }

        /// <summary>
        /// Gets or Sets TopLevelCategoryGuid
        /// </summary>
        [DataMember(Name = "top_level_category_guid", EmitDefaultValue = true)]
        public string TopLevelCategoryGuid { get; set; }

        /// <summary>
        /// Gets or Sets TransactionGuids
        /// </summary>
        [DataMember(Name = "transaction_guids", EmitDefaultValue = false)]
        public List<string> TransactionGuids { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = true)]
        public string UpdatedAt { get; set; }

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
            sb.Append("class SpendingPlanIterationItemResponse {\n");
            sb.Append("  ActualAmount: ").Append(ActualAmount).Append("\n");
            sb.Append("  CategoryGuid: ").Append(CategoryGuid).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  ItemType: ").Append(ItemType).Append("\n");
            sb.Append("  PlannedAmount: ").Append(PlannedAmount).Append("\n");
            sb.Append("  ScheduledPaymentGuid: ").Append(ScheduledPaymentGuid).Append("\n");
            sb.Append("  SpendingPlanIterationGuid: ").Append(SpendingPlanIterationGuid).Append("\n");
            sb.Append("  TopLevelCategoryGuid: ").Append(TopLevelCategoryGuid).Append("\n");
            sb.Append("  TransactionGuids: ").Append(TransactionGuids).Append("\n");
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
            return this.Equals(input as SpendingPlanIterationItemResponse);
        }

        /// <summary>
        /// Returns true if SpendingPlanIterationItemResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SpendingPlanIterationItemResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpendingPlanIterationItemResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActualAmount == input.ActualAmount ||
                    (this.ActualAmount != null &&
                    this.ActualAmount.Equals(input.ActualAmount))
                ) && 
                (
                    this.CategoryGuid == input.CategoryGuid ||
                    (this.CategoryGuid != null &&
                    this.CategoryGuid.Equals(input.CategoryGuid))
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
                    this.ItemType == input.ItemType ||
                    (this.ItemType != null &&
                    this.ItemType.Equals(input.ItemType))
                ) && 
                (
                    this.PlannedAmount == input.PlannedAmount ||
                    (this.PlannedAmount != null &&
                    this.PlannedAmount.Equals(input.PlannedAmount))
                ) && 
                (
                    this.ScheduledPaymentGuid == input.ScheduledPaymentGuid ||
                    (this.ScheduledPaymentGuid != null &&
                    this.ScheduledPaymentGuid.Equals(input.ScheduledPaymentGuid))
                ) && 
                (
                    this.SpendingPlanIterationGuid == input.SpendingPlanIterationGuid ||
                    (this.SpendingPlanIterationGuid != null &&
                    this.SpendingPlanIterationGuid.Equals(input.SpendingPlanIterationGuid))
                ) && 
                (
                    this.TopLevelCategoryGuid == input.TopLevelCategoryGuid ||
                    (this.TopLevelCategoryGuid != null &&
                    this.TopLevelCategoryGuid.Equals(input.TopLevelCategoryGuid))
                ) && 
                (
                    this.TransactionGuids == input.TransactionGuids ||
                    this.TransactionGuids != null &&
                    input.TransactionGuids != null &&
                    this.TransactionGuids.SequenceEqual(input.TransactionGuids)
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
                if (this.ActualAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ActualAmount.GetHashCode();
                }
                if (this.CategoryGuid != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryGuid.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.ItemType != null)
                {
                    hashCode = (hashCode * 59) + this.ItemType.GetHashCode();
                }
                if (this.PlannedAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PlannedAmount.GetHashCode();
                }
                if (this.ScheduledPaymentGuid != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledPaymentGuid.GetHashCode();
                }
                if (this.SpendingPlanIterationGuid != null)
                {
                    hashCode = (hashCode * 59) + this.SpendingPlanIterationGuid.GetHashCode();
                }
                if (this.TopLevelCategoryGuid != null)
                {
                    hashCode = (hashCode * 59) + this.TopLevelCategoryGuid.GetHashCode();
                }
                if (this.TransactionGuids != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionGuids.GetHashCode();
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

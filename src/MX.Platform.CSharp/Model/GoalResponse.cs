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
    /// GoalResponse
    /// </summary>
    [DataContract(Name = "GoalResponse")]
    public partial class GoalResponse : IEquatable<GoalResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoalResponse" /> class.
        /// </summary>
        /// <param name="accountGuid">Unique identifier of the account for the goal..</param>
        /// <param name="amount">Amount of the goal..</param>
        /// <param name="completedAt">Date and time the goal was completed..</param>
        /// <param name="currentAmount">The current amount of the goal..</param>
        /// <param name="goalTypeName">The goal type..</param>
        /// <param name="guid">Unique identifier for the goal. Defined by MX..</param>
        /// <param name="hasBeenSpent">Determines if the goal has been spent..</param>
        /// <param name="isComplete">Determines if the goal is complete..</param>
        /// <param name="metadata">Additional information a partner can store on the goal..</param>
        /// <param name="metaTypeName">The category of the goal..</param>
        /// <param name="name">The name of the goal..</param>
        /// <param name="position">The priority of the goal in relation to multiple goals..</param>
        /// <param name="projectedToCompleteAt">Date and time the goal is projected to be completed..</param>
        /// <param name="targetedToCompleteAt">Date and time the goal is to complete. Intended for users to set their own goal completion dates..</param>
        /// <param name="trackTypeName">trackTypeName.</param>
        /// <param name="userGuid">The unique identifier for the the user. Defined by MX..</param>
        public GoalResponse(string accountGuid = default(string), decimal amount = default(decimal), string completedAt = default(string), decimal currentAmount = default(decimal), string goalTypeName = default(string), string guid = default(string), bool hasBeenSpent = default(bool), bool isComplete = default(bool), string metadata = default(string), string metaTypeName = default(string), string name = default(string), int position = default(int), string projectedToCompleteAt = default(string), string targetedToCompleteAt = default(string), string trackTypeName = default(string), string userGuid = default(string))
        {
            this.AccountGuid = accountGuid;
            this.Amount = amount;
            this.CompletedAt = completedAt;
            this.CurrentAmount = currentAmount;
            this.GoalTypeName = goalTypeName;
            this.Guid = guid;
            this.HasBeenSpent = hasBeenSpent;
            this.IsComplete = isComplete;
            this.Metadata = metadata;
            this.MetaTypeName = metaTypeName;
            this.Name = name;
            this.Position = position;
            this.ProjectedToCompleteAt = projectedToCompleteAt;
            this.TargetedToCompleteAt = targetedToCompleteAt;
            this.TrackTypeName = trackTypeName;
            this.UserGuid = userGuid;
        }

        /// <summary>
        /// Unique identifier of the account for the goal.
        /// </summary>
        /// <value>Unique identifier of the account for the goal.</value>
        /// <example>ACT-4e431124-4a29-abf9-f059-ab232ac14dbf</example>
        [DataMember(Name = "account_guid", EmitDefaultValue = false)]
        public string AccountGuid { get; set; }

        /// <summary>
        /// Amount of the goal.
        /// </summary>
        /// <value>Amount of the goal.</value>
        /// <example>4500.0</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Date and time the goal was completed.
        /// </summary>
        /// <value>Date and time the goal was completed.</value>
        /// <example>2015-06-19T10:37:04-06:00</example>
        [DataMember(Name = "completed_at", EmitDefaultValue = false)]
        public string CompletedAt { get; set; }

        /// <summary>
        /// The current amount of the goal.
        /// </summary>
        /// <value>The current amount of the goal.</value>
        /// <example>1651.27</example>
        [DataMember(Name = "current_amount", EmitDefaultValue = false)]
        public decimal CurrentAmount { get; set; }

        /// <summary>
        /// The goal type.
        /// </summary>
        /// <value>The goal type.</value>
        /// <example>PAYOFF</example>
        [DataMember(Name = "goal_type_name", EmitDefaultValue = false)]
        public string GoalTypeName { get; set; }

        /// <summary>
        /// Unique identifier for the goal. Defined by MX.
        /// </summary>
        /// <value>Unique identifier for the goal. Defined by MX.</value>
        /// <example>GOL-f223463-4355-48d0-rce7-fe2rb345617c</example>
        [DataMember(Name = "guid", EmitDefaultValue = false)]
        public string Guid { get; set; }

        /// <summary>
        /// Determines if the goal has been spent.
        /// </summary>
        /// <value>Determines if the goal has been spent.</value>
        /// <example>false</example>
        [DataMember(Name = "has_been_spent", EmitDefaultValue = true)]
        public bool HasBeenSpent { get; set; }

        /// <summary>
        /// Determines if the goal is complete.
        /// </summary>
        /// <value>Determines if the goal is complete.</value>
        /// <example>false</example>
        [DataMember(Name = "is_complete", EmitDefaultValue = true)]
        public bool IsComplete { get; set; }

        /// <summary>
        /// Additional information a partner can store on the goal.
        /// </summary>
        /// <value>Additional information a partner can store on the goal.</value>
        /// <example>Additional information</example>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// The category of the goal.
        /// </summary>
        /// <value>The category of the goal.</value>
        /// <example>VACATION</example>
        [DataMember(Name = "meta_type_name", EmitDefaultValue = false)]
        public string MetaTypeName { get; set; }

        /// <summary>
        /// The name of the goal.
        /// </summary>
        /// <value>The name of the goal.</value>
        /// <example>Save for Europe</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The priority of the goal in relation to multiple goals.
        /// </summary>
        /// <value>The priority of the goal in relation to multiple goals.</value>
        /// <example>3</example>
        [DataMember(Name = "position", EmitDefaultValue = false)]
        public int Position { get; set; }

        /// <summary>
        /// Date and time the goal is projected to be completed.
        /// </summary>
        /// <value>Date and time the goal is projected to be completed.</value>
        /// <example>2022-06-14T16:03:53-00:00</example>
        [DataMember(Name = "projected_to_complete_at", EmitDefaultValue = false)]
        public string ProjectedToCompleteAt { get; set; }

        /// <summary>
        /// Date and time the goal is to complete. Intended for users to set their own goal completion dates.
        /// </summary>
        /// <value>Date and time the goal is to complete. Intended for users to set their own goal completion dates.</value>
        /// <example>2026-12-08 00:00:00.000000</example>
        [DataMember(Name = "targeted_to_complete_at", EmitDefaultValue = false)]
        public string TargetedToCompleteAt { get; set; }

        /// <summary>
        /// Gets or Sets TrackTypeName
        /// </summary>
        /// <example>Track Type Name</example>
        [DataMember(Name = "track_type_name", EmitDefaultValue = false)]
        public string TrackTypeName { get; set; }

        /// <summary>
        /// The unique identifier for the the user. Defined by MX.
        /// </summary>
        /// <value>The unique identifier for the the user. Defined by MX.</value>
        /// <example>USR-11141024-90b3-1bce-cac9-c06ced52ab4c</example>
        [DataMember(Name = "user_guid", EmitDefaultValue = false)]
        public string UserGuid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoalResponse {\n");
            sb.Append("  AccountGuid: ").Append(AccountGuid).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CompletedAt: ").Append(CompletedAt).Append("\n");
            sb.Append("  CurrentAmount: ").Append(CurrentAmount).Append("\n");
            sb.Append("  GoalTypeName: ").Append(GoalTypeName).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  HasBeenSpent: ").Append(HasBeenSpent).Append("\n");
            sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MetaTypeName: ").Append(MetaTypeName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  ProjectedToCompleteAt: ").Append(ProjectedToCompleteAt).Append("\n");
            sb.Append("  TargetedToCompleteAt: ").Append(TargetedToCompleteAt).Append("\n");
            sb.Append("  TrackTypeName: ").Append(TrackTypeName).Append("\n");
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
            return this.Equals(input as GoalResponse);
        }

        /// <summary>
        /// Returns true if GoalResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GoalResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoalResponse input)
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
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.CompletedAt == input.CompletedAt ||
                    (this.CompletedAt != null &&
                    this.CompletedAt.Equals(input.CompletedAt))
                ) && 
                (
                    this.CurrentAmount == input.CurrentAmount ||
                    this.CurrentAmount.Equals(input.CurrentAmount)
                ) && 
                (
                    this.GoalTypeName == input.GoalTypeName ||
                    (this.GoalTypeName != null &&
                    this.GoalTypeName.Equals(input.GoalTypeName))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.HasBeenSpent == input.HasBeenSpent ||
                    this.HasBeenSpent.Equals(input.HasBeenSpent)
                ) && 
                (
                    this.IsComplete == input.IsComplete ||
                    this.IsComplete.Equals(input.IsComplete)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.MetaTypeName == input.MetaTypeName ||
                    (this.MetaTypeName != null &&
                    this.MetaTypeName.Equals(input.MetaTypeName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    this.Position.Equals(input.Position)
                ) && 
                (
                    this.ProjectedToCompleteAt == input.ProjectedToCompleteAt ||
                    (this.ProjectedToCompleteAt != null &&
                    this.ProjectedToCompleteAt.Equals(input.ProjectedToCompleteAt))
                ) && 
                (
                    this.TargetedToCompleteAt == input.TargetedToCompleteAt ||
                    (this.TargetedToCompleteAt != null &&
                    this.TargetedToCompleteAt.Equals(input.TargetedToCompleteAt))
                ) && 
                (
                    this.TrackTypeName == input.TrackTypeName ||
                    (this.TrackTypeName != null &&
                    this.TrackTypeName.Equals(input.TrackTypeName))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.CompletedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CompletedAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CurrentAmount.GetHashCode();
                if (this.GoalTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.GoalTypeName.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasBeenSpent.GetHashCode();
                hashCode = (hashCode * 59) + this.IsComplete.GetHashCode();
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.MetaTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.MetaTypeName.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Position.GetHashCode();
                if (this.ProjectedToCompleteAt != null)
                {
                    hashCode = (hashCode * 59) + this.ProjectedToCompleteAt.GetHashCode();
                }
                if (this.TargetedToCompleteAt != null)
                {
                    hashCode = (hashCode * 59) + this.TargetedToCompleteAt.GetHashCode();
                }
                if (this.TrackTypeName != null)
                {
                    hashCode = (hashCode * 59) + this.TrackTypeName.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

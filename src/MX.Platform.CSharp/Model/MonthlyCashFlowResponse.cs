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
    /// MonthlyCashFlowResponse
    /// </summary>
    [DataContract(Name = "MonthlyCashFlowResponse")]
    public partial class MonthlyCashFlowResponse : IEquatable<MonthlyCashFlowResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MonthlyCashFlowResponse" /> class.
        /// </summary>
        /// <param name="guid">Unique identifier for the monthly cash flow profile. Defined by MX..</param>
        /// <param name="userGuid">Unique identifier for the user the monthly cash flow profile is attached to. Defined by MX..</param>
        /// <param name="budgetedIncome">The amount of the budgeted income for the user..</param>
        /// <param name="budgetedExpenses">The amount of the budgeted expenses for the user..</param>
        /// <param name="goalsContribution">The monthly dollar amount allocated for goals..</param>
        /// <param name="estimatedGoalsContribution">The estimated monthly dollar amount allocated for goals calculated from income and budgets..</param>
        /// <param name="usesEstimatedGoalsContribution">usesEstimatedGoalsContribution.</param>
        public MonthlyCashFlowResponse(string guid = default(string), string userGuid = default(string), decimal budgetedIncome = default(decimal), decimal budgetedExpenses = default(decimal), decimal goalsContribution = default(decimal), int estimatedGoalsContribution = default(int), bool usesEstimatedGoalsContribution = default(bool))
        {
            this.Guid = guid;
            this.UserGuid = userGuid;
            this.BudgetedIncome = budgetedIncome;
            this.BudgetedExpenses = budgetedExpenses;
            this.GoalsContribution = goalsContribution;
            this.EstimatedGoalsContribution = estimatedGoalsContribution;
            this.UsesEstimatedGoalsContribution = usesEstimatedGoalsContribution;
        }

        /// <summary>
        /// Unique identifier for the monthly cash flow profile. Defined by MX.
        /// </summary>
        /// <value>Unique identifier for the monthly cash flow profile. Defined by MX.</value>
        /// <example>MCF-4e431124-4a29-abf9-f059-ab232ac14dbf</example>
        [DataMember(Name = "guid", EmitDefaultValue = false)]
        public string Guid { get; set; }

        /// <summary>
        /// Unique identifier for the user the monthly cash flow profile is attached to. Defined by MX.
        /// </summary>
        /// <value>Unique identifier for the user the monthly cash flow profile is attached to. Defined by MX.</value>
        /// <example>USR-6c83f63c-efcc-0189-3f14-100f0bad378a</example>
        [DataMember(Name = "user_guid", EmitDefaultValue = false)]
        public string UserGuid { get; set; }

        /// <summary>
        /// The amount of the budgeted income for the user.
        /// </summary>
        /// <value>The amount of the budgeted income for the user.</value>
        /// <example>1200.12</example>
        [DataMember(Name = "budgeted_income", EmitDefaultValue = false)]
        public decimal BudgetedIncome { get; set; }

        /// <summary>
        /// The amount of the budgeted expenses for the user.
        /// </summary>
        /// <value>The amount of the budgeted expenses for the user.</value>
        /// <example>1000.0</example>
        [DataMember(Name = "budgeted_expenses", EmitDefaultValue = false)]
        public decimal BudgetedExpenses { get; set; }

        /// <summary>
        /// The monthly dollar amount allocated for goals.
        /// </summary>
        /// <value>The monthly dollar amount allocated for goals.</value>
        /// <example>150.0</example>
        [DataMember(Name = "goals_contribution", EmitDefaultValue = false)]
        public decimal GoalsContribution { get; set; }

        /// <summary>
        /// The estimated monthly dollar amount allocated for goals calculated from income and budgets.
        /// </summary>
        /// <value>The estimated monthly dollar amount allocated for goals calculated from income and budgets.</value>
        [DataMember(Name = "estimated_goals_contribution", EmitDefaultValue = false)]
        public int EstimatedGoalsContribution { get; set; }

        /// <summary>
        /// Gets or Sets UsesEstimatedGoalsContribution
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "uses_estimated_goals_contribution", EmitDefaultValue = true)]
        public bool UsesEstimatedGoalsContribution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MonthlyCashFlowResponse {\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  UserGuid: ").Append(UserGuid).Append("\n");
            sb.Append("  BudgetedIncome: ").Append(BudgetedIncome).Append("\n");
            sb.Append("  BudgetedExpenses: ").Append(BudgetedExpenses).Append("\n");
            sb.Append("  GoalsContribution: ").Append(GoalsContribution).Append("\n");
            sb.Append("  EstimatedGoalsContribution: ").Append(EstimatedGoalsContribution).Append("\n");
            sb.Append("  UsesEstimatedGoalsContribution: ").Append(UsesEstimatedGoalsContribution).Append("\n");
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
            return this.Equals(input as MonthlyCashFlowResponse);
        }

        /// <summary>
        /// Returns true if MonthlyCashFlowResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of MonthlyCashFlowResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MonthlyCashFlowResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.UserGuid == input.UserGuid ||
                    (this.UserGuid != null &&
                    this.UserGuid.Equals(input.UserGuid))
                ) && 
                (
                    this.BudgetedIncome == input.BudgetedIncome ||
                    this.BudgetedIncome.Equals(input.BudgetedIncome)
                ) && 
                (
                    this.BudgetedExpenses == input.BudgetedExpenses ||
                    this.BudgetedExpenses.Equals(input.BudgetedExpenses)
                ) && 
                (
                    this.GoalsContribution == input.GoalsContribution ||
                    this.GoalsContribution.Equals(input.GoalsContribution)
                ) && 
                (
                    this.EstimatedGoalsContribution == input.EstimatedGoalsContribution ||
                    this.EstimatedGoalsContribution.Equals(input.EstimatedGoalsContribution)
                ) && 
                (
                    this.UsesEstimatedGoalsContribution == input.UsesEstimatedGoalsContribution ||
                    this.UsesEstimatedGoalsContribution.Equals(input.UsesEstimatedGoalsContribution)
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
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.UserGuid != null)
                {
                    hashCode = (hashCode * 59) + this.UserGuid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BudgetedIncome.GetHashCode();
                hashCode = (hashCode * 59) + this.BudgetedExpenses.GetHashCode();
                hashCode = (hashCode * 59) + this.GoalsContribution.GetHashCode();
                hashCode = (hashCode * 59) + this.EstimatedGoalsContribution.GetHashCode();
                hashCode = (hashCode * 59) + this.UsesEstimatedGoalsContribution.GetHashCode();
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

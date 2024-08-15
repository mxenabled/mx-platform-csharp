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
    /// BudgetUpdateRequest
    /// </summary>
    [DataContract(Name = "BudgetUpdateRequest")]
    public partial class BudgetUpdateRequest : IEquatable<BudgetUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetUpdateRequest" /> class.
        /// </summary>
        /// <param name="amount">Amount of the budget..</param>
        /// <param name="metadata">Additional information a partner can store on the budget..</param>
        /// <param name="skipWebhook">When set to true, this parameter will prevent a webhook from being triggered by the request..</param>
        public BudgetUpdateRequest(int amount = default(int), string metadata = default(string), bool skipWebhook = default(bool))
        {
            this.Amount = amount;
            this.Metadata = metadata;
            this.SkipWebhook = skipWebhook;
        }

        /// <summary>
        /// Amount of the budget.
        /// </summary>
        /// <value>Amount of the budget.</value>
        /// <example>1000</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public int Amount { get; set; }

        /// <summary>
        /// Additional information a partner can store on the budget.
        /// </summary>
        /// <value>Additional information a partner can store on the budget.</value>
        /// <example>Additional information</example>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// When set to true, this parameter will prevent a webhook from being triggered by the request.
        /// </summary>
        /// <value>When set to true, this parameter will prevent a webhook from being triggered by the request.</value>
        /// <example>true</example>
        [DataMember(Name = "skip_webhook", EmitDefaultValue = true)]
        public bool SkipWebhook { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BudgetUpdateRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  SkipWebhook: ").Append(SkipWebhook).Append("\n");
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
            return this.Equals(input as BudgetUpdateRequest);
        }

        /// <summary>
        /// Returns true if BudgetUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.SkipWebhook == input.SkipWebhook ||
                    this.SkipWebhook.Equals(input.SkipWebhook)
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SkipWebhook.GetHashCode();
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

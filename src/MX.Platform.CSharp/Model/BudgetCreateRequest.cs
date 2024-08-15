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
    /// BudgetCreateRequest
    /// </summary>
    [DataContract(Name = "BudgetCreateRequest")]
    public partial class BudgetCreateRequest : IEquatable<BudgetCreateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetCreateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BudgetCreateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetCreateRequest" /> class.
        /// </summary>
        /// <param name="categoryGuid">Unique identifier of the category. (required).</param>
        /// <param name="parentGuid">Unique identifier of the parent budget. This is only required when creating a budget on a sub-category. (required).</param>
        /// <param name="amount">Amount of the budget..</param>
        /// <param name="metadata">Additional information a partner can store on the budget..</param>
        /// <param name="skipWebhook">When set to true, this parameter will prevent a webhook from being triggered by the request..</param>
        public BudgetCreateRequest(string categoryGuid = default(string), string parentGuid = default(string), int amount = default(int), string metadata = default(string), bool skipWebhook = default(bool))
        {
            // to ensure "categoryGuid" is required (not null)
            if (categoryGuid == null)
            {
                throw new ArgumentNullException("categoryGuid is a required property for BudgetCreateRequest and cannot be null");
            }
            this.CategoryGuid = categoryGuid;
            // to ensure "parentGuid" is required (not null)
            if (parentGuid == null)
            {
                throw new ArgumentNullException("parentGuid is a required property for BudgetCreateRequest and cannot be null");
            }
            this.ParentGuid = parentGuid;
            this.Amount = amount;
            this.Metadata = metadata;
            this.SkipWebhook = skipWebhook;
        }

        /// <summary>
        /// Unique identifier of the category.
        /// </summary>
        /// <value>Unique identifier of the category.</value>
        /// <example>CAT-bd56d35a-a9a7-6e10-66c1-5b9cc1b6c81a</example>
        [DataMember(Name = "category_guid", IsRequired = true, EmitDefaultValue = true)]
        public string CategoryGuid { get; set; }

        /// <summary>
        /// Unique identifier of the parent budget. This is only required when creating a budget on a sub-category.
        /// </summary>
        /// <value>Unique identifier of the parent budget. This is only required when creating a budget on a sub-category.</value>
        /// <example>BGT-6be44a91-e105-f68a-4770-8c7c0a5c9778</example>
        [DataMember(Name = "parent_guid", IsRequired = true, EmitDefaultValue = true)]
        public string ParentGuid { get; set; }

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
            sb.Append("class BudgetCreateRequest {\n");
            sb.Append("  CategoryGuid: ").Append(CategoryGuid).Append("\n");
            sb.Append("  ParentGuid: ").Append(ParentGuid).Append("\n");
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
            return this.Equals(input as BudgetCreateRequest);
        }

        /// <summary>
        /// Returns true if BudgetCreateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetCreateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetCreateRequest input)
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
                    this.ParentGuid == input.ParentGuid ||
                    (this.ParentGuid != null &&
                    this.ParentGuid.Equals(input.ParentGuid))
                ) && 
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
                if (this.CategoryGuid != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryGuid.GetHashCode();
                }
                if (this.ParentGuid != null)
                {
                    hashCode = (hashCode * 59) + this.ParentGuid.GetHashCode();
                }
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
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
    /// EnhanceTransactionsRequest
    /// </summary>
    [DataContract(Name = "EnhanceTransactionsRequest")]
    public partial class EnhanceTransactionsRequest : IEquatable<EnhanceTransactionsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnhanceTransactionsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EnhanceTransactionsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EnhanceTransactionsRequest" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="description">description (required).</param>
        /// <param name="extendedTransactionType">extendedTransactionType.</param>
        /// <param name="id">id (required).</param>
        /// <param name="memo">memo.</param>
        /// <param name="merchantCategoryCode">merchantCategoryCode.</param>
        /// <param name="type">type.</param>
        public EnhanceTransactionsRequest(decimal amount = default(decimal), string description = default(string), string extendedTransactionType = default(string), string id = default(string), string memo = default(string), int merchantCategoryCode = default(int), string type = default(string))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for EnhanceTransactionsRequest and cannot be null");
            }
            this.Description = description;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for EnhanceTransactionsRequest and cannot be null");
            }
            this.Id = id;
            this.Amount = amount;
            this.ExtendedTransactionType = extendedTransactionType;
            this.Memo = memo;
            this.MerchantCategoryCode = merchantCategoryCode;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        /// <example>21.33</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal Amount { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        /// <example>ubr* pending.uber.com</example>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets ExtendedTransactionType
        /// </summary>
        /// <example>partner_transaction_type</example>
        [DataMember(Name = "extended_transaction_type", EmitDefaultValue = false)]
        public string ExtendedTransactionType { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>ID-123</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Memo
        /// </summary>
        /// <example>Additional-information*on_transaction</example>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or Sets MerchantCategoryCode
        /// </summary>
        /// <example>4121</example>
        [DataMember(Name = "merchant_category_code", EmitDefaultValue = false)]
        public int MerchantCategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>DEBIT</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnhanceTransactionsRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExtendedTransactionType: ").Append(ExtendedTransactionType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as EnhanceTransactionsRequest);
        }

        /// <summary>
        /// Returns true if EnhanceTransactionsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EnhanceTransactionsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnhanceTransactionsRequest input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExtendedTransactionType == input.ExtendedTransactionType ||
                    (this.ExtendedTransactionType != null &&
                    this.ExtendedTransactionType.Equals(input.ExtendedTransactionType))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.MerchantCategoryCode == input.MerchantCategoryCode ||
                    this.MerchantCategoryCode.Equals(input.MerchantCategoryCode)
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ExtendedTransactionType != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendedTransactionType.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MerchantCategoryCode.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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

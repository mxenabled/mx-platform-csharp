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
    /// TransactionRuleCreateRequestBody
    /// </summary>
    [DataContract(Name = "TransactionRuleCreateRequestBody")]
    public partial class TransactionRuleCreateRequestBody : IEquatable<TransactionRuleCreateRequestBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRuleCreateRequestBody" /> class.
        /// </summary>
        /// <param name="transactionRule">transactionRule.</param>
        public TransactionRuleCreateRequestBody(TransactionRuleCreateRequest transactionRule = default(TransactionRuleCreateRequest))
        {
            this.TransactionRule = transactionRule;
        }

        /// <summary>
        /// Gets or Sets TransactionRule
        /// </summary>
        [DataMember(Name = "transaction_rule", EmitDefaultValue = false)]
        public TransactionRuleCreateRequest TransactionRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionRuleCreateRequestBody {\n");
            sb.Append("  TransactionRule: ").Append(TransactionRule).Append("\n");
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
            return this.Equals(input as TransactionRuleCreateRequestBody);
        }

        /// <summary>
        /// Returns true if TransactionRuleCreateRequestBody instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRuleCreateRequestBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRuleCreateRequestBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TransactionRule == input.TransactionRule ||
                    (this.TransactionRule != null &&
                    this.TransactionRule.Equals(input.TransactionRule))
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
                if (this.TransactionRule != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionRule.GetHashCode();
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

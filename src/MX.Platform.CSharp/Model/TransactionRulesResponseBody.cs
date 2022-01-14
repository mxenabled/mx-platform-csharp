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
    /// TransactionRulesResponseBody
    /// </summary>
    [DataContract(Name = "TransactionRulesResponseBody")]
    public partial class TransactionRulesResponseBody : IEquatable<TransactionRulesResponseBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRulesResponseBody" /> class.
        /// </summary>
        /// <param name="pagination">pagination.</param>
        /// <param name="transactionRules">transactionRules.</param>
        public TransactionRulesResponseBody(PaginationResponse pagination = default(PaginationResponse), List<TransactionRuleResponse> transactionRules = default(List<TransactionRuleResponse>))
        {
            this.Pagination = pagination;
            this.TransactionRules = transactionRules;
        }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public PaginationResponse Pagination { get; set; }

        /// <summary>
        /// Gets or Sets TransactionRules
        /// </summary>
        [DataMember(Name = "transaction_rules", EmitDefaultValue = false)]
        public List<TransactionRuleResponse> TransactionRules { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionRulesResponseBody {\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  TransactionRules: ").Append(TransactionRules).Append("\n");
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
            return this.Equals(input as TransactionRulesResponseBody);
        }

        /// <summary>
        /// Returns true if TransactionRulesResponseBody instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRulesResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRulesResponseBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.TransactionRules == input.TransactionRules ||
                    this.TransactionRules != null &&
                    input.TransactionRules != null &&
                    this.TransactionRules.SequenceEqual(input.TransactionRules)
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
                if (this.Pagination != null)
                {
                    hashCode = (hashCode * 59) + this.Pagination.GetHashCode();
                }
                if (this.TransactionRules != null)
                {
                    hashCode = (hashCode * 59) + this.TransactionRules.GetHashCode();
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

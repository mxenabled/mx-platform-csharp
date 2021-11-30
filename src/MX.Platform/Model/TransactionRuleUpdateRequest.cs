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
using OpenAPIDateConverter = MX.Platform.Client.OpenAPIDateConverter;

namespace MX.Platform.Model
{
    /// <summary>
    /// TransactionRuleUpdateRequest
    /// </summary>
    [DataContract(Name = "TransactionRuleUpdateRequest")]
    public partial class TransactionRuleUpdateRequest : IEquatable<TransactionRuleUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRuleUpdateRequest" /> class.
        /// </summary>
        /// <param name="categoryGuid">categoryGuid.</param>
        /// <param name="description">description.</param>
        /// <param name="matchDescription">matchDescription.</param>
        public TransactionRuleUpdateRequest(string categoryGuid = default(string), string description = default(string), string matchDescription = default(string))
        {
            this.CategoryGuid = categoryGuid;
            this.Description = description;
            this.MatchDescription = matchDescription;
        }

        /// <summary>
        /// Gets or Sets CategoryGuid
        /// </summary>
        [DataMember(Name = "category_guid", EmitDefaultValue = false)]
        public string CategoryGuid { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets MatchDescription
        /// </summary>
        [DataMember(Name = "match_description", EmitDefaultValue = true)]
        public string MatchDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionRuleUpdateRequest {\n");
            sb.Append("  CategoryGuid: ").Append(CategoryGuid).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  MatchDescription: ").Append(MatchDescription).Append("\n");
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
            return this.Equals(input as TransactionRuleUpdateRequest);
        }

        /// <summary>
        /// Returns true if TransactionRuleUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRuleUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRuleUpdateRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CategoryGuid == input.CategoryGuid ||
                    (this.CategoryGuid != null &&
                    this.CategoryGuid.Equals(input.CategoryGuid))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.MatchDescription == input.MatchDescription ||
                    (this.MatchDescription != null &&
                    this.MatchDescription.Equals(input.MatchDescription))
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
                    hashCode = hashCode * 59 + this.CategoryGuid.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.MatchDescription != null)
                    hashCode = hashCode * 59 + this.MatchDescription.GetHashCode();
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

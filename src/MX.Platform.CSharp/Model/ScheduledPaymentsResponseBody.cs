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
    /// ScheduledPaymentsResponseBody
    /// </summary>
    [DataContract(Name = "ScheduledPaymentsResponseBody")]
    public partial class ScheduledPaymentsResponseBody : IEquatable<ScheduledPaymentsResponseBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledPaymentsResponseBody" /> class.
        /// </summary>
        /// <param name="pagination">pagination.</param>
        /// <param name="scheduledPayments">scheduledPayments.</param>
        public ScheduledPaymentsResponseBody(PaginationResponse pagination = default(PaginationResponse), List<ScheduledPaymentResponse> scheduledPayments = default(List<ScheduledPaymentResponse>))
        {
            this.Pagination = pagination;
            this.ScheduledPayments = scheduledPayments;
        }

        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name = "pagination", EmitDefaultValue = false)]
        public PaginationResponse Pagination { get; set; }

        /// <summary>
        /// Gets or Sets ScheduledPayments
        /// </summary>
        [DataMember(Name = "scheduled_payments", EmitDefaultValue = false)]
        public List<ScheduledPaymentResponse> ScheduledPayments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduledPaymentsResponseBody {\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  ScheduledPayments: ").Append(ScheduledPayments).Append("\n");
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
            return this.Equals(input as ScheduledPaymentsResponseBody);
        }

        /// <summary>
        /// Returns true if ScheduledPaymentsResponseBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduledPaymentsResponseBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledPaymentsResponseBody input)
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
                    this.ScheduledPayments == input.ScheduledPayments ||
                    this.ScheduledPayments != null &&
                    input.ScheduledPayments != null &&
                    this.ScheduledPayments.SequenceEqual(input.ScheduledPayments)
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
                if (this.ScheduledPayments != null)
                {
                    hashCode = (hashCode * 59) + this.ScheduledPayments.GetHashCode();
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

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
    /// SpendingPlanIterationResponse
    /// </summary>
    [DataContract(Name = "SpendingPlanIterationResponse")]
    public partial class SpendingPlanIterationResponse : IEquatable<SpendingPlanIterationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpendingPlanIterationResponse" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="endOn">endOn.</param>
        /// <param name="guid">guid.</param>
        /// <param name="iterationNumber">iterationNumber.</param>
        /// <param name="spendingPlanGuid">spendingPlanGuid.</param>
        /// <param name="startOn">startOn.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="userGuid">userGuid.</param>
        public SpendingPlanIterationResponse(string createdAt = default(string), string endOn = default(string), string guid = default(string), int? iterationNumber = default(int?), string spendingPlanGuid = default(string), string startOn = default(string), string updatedAt = default(string), string userGuid = default(string))
        {
            this.CreatedAt = createdAt;
            this.EndOn = endOn;
            this.Guid = guid;
            this.IterationNumber = iterationNumber;
            this.SpendingPlanGuid = spendingPlanGuid;
            this.StartOn = startOn;
            this.UpdatedAt = updatedAt;
            this.UserGuid = userGuid;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets EndOn
        /// </summary>
        [DataMember(Name = "end_on", EmitDefaultValue = true)]
        public string EndOn { get; set; }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        [DataMember(Name = "guid", EmitDefaultValue = true)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets IterationNumber
        /// </summary>
        [DataMember(Name = "iteration_number", EmitDefaultValue = true)]
        public int? IterationNumber { get; set; }

        /// <summary>
        /// Gets or Sets SpendingPlanGuid
        /// </summary>
        [DataMember(Name = "spending_plan_guid", EmitDefaultValue = true)]
        public string SpendingPlanGuid { get; set; }

        /// <summary>
        /// Gets or Sets StartOn
        /// </summary>
        [DataMember(Name = "start_on", EmitDefaultValue = true)]
        public string StartOn { get; set; }

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
            sb.Append("class SpendingPlanIterationResponse {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EndOn: ").Append(EndOn).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  IterationNumber: ").Append(IterationNumber).Append("\n");
            sb.Append("  SpendingPlanGuid: ").Append(SpendingPlanGuid).Append("\n");
            sb.Append("  StartOn: ").Append(StartOn).Append("\n");
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
            return this.Equals(input as SpendingPlanIterationResponse);
        }

        /// <summary>
        /// Returns true if SpendingPlanIterationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SpendingPlanIterationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpendingPlanIterationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.EndOn == input.EndOn ||
                    (this.EndOn != null &&
                    this.EndOn.Equals(input.EndOn))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.IterationNumber == input.IterationNumber ||
                    (this.IterationNumber != null &&
                    this.IterationNumber.Equals(input.IterationNumber))
                ) && 
                (
                    this.SpendingPlanGuid == input.SpendingPlanGuid ||
                    (this.SpendingPlanGuid != null &&
                    this.SpendingPlanGuid.Equals(input.SpendingPlanGuid))
                ) && 
                (
                    this.StartOn == input.StartOn ||
                    (this.StartOn != null &&
                    this.StartOn.Equals(input.StartOn))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.EndOn != null)
                {
                    hashCode = (hashCode * 59) + this.EndOn.GetHashCode();
                }
                if (this.Guid != null)
                {
                    hashCode = (hashCode * 59) + this.Guid.GetHashCode();
                }
                if (this.IterationNumber != null)
                {
                    hashCode = (hashCode * 59) + this.IterationNumber.GetHashCode();
                }
                if (this.SpendingPlanGuid != null)
                {
                    hashCode = (hashCode * 59) + this.SpendingPlanGuid.GetHashCode();
                }
                if (this.StartOn != null)
                {
                    hashCode = (hashCode * 59) + this.StartOn.GetHashCode();
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
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
    /// MemberResumeRequest
    /// </summary>
    [DataContract(Name = "MemberResumeRequest")]
    public partial class MemberResumeRequest : IEquatable<MemberResumeRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MemberResumeRequest" /> class.
        /// </summary>
        /// <param name="challenges">challenges.</param>
        public MemberResumeRequest(List<CredentialRequest> challenges = default(List<CredentialRequest>))
        {
            this.Challenges = challenges;
        }

        /// <summary>
        /// Gets or Sets Challenges
        /// </summary>
        [DataMember(Name = "challenges", EmitDefaultValue = false)]
        public List<CredentialRequest> Challenges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MemberResumeRequest {\n");
            sb.Append("  Challenges: ").Append(Challenges).Append("\n");
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
            return this.Equals(input as MemberResumeRequest);
        }

        /// <summary>
        /// Returns true if MemberResumeRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MemberResumeRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MemberResumeRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Challenges == input.Challenges ||
                    this.Challenges != null &&
                    input.Challenges != null &&
                    this.Challenges.SequenceEqual(input.Challenges)
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
                if (this.Challenges != null)
                {
                    hashCode = (hashCode * 59) + this.Challenges.GetHashCode();
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

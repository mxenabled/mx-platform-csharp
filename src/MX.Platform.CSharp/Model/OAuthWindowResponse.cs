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
    /// OAuthWindowResponse
    /// </summary>
    [DataContract(Name = "OAuthWindowResponse")]
    public partial class OAuthWindowResponse : IEquatable<OAuthWindowResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthWindowResponse" /> class.
        /// </summary>
        /// <param name="guid">guid.</param>
        /// <param name="oauthWindowUri">oauthWindowUri.</param>
        public OAuthWindowResponse(string guid = default(string), string oauthWindowUri = default(string))
        {
            this.Guid = guid;
            this.OauthWindowUri = oauthWindowUri;
        }

        /// <summary>
        /// Gets or Sets Guid
        /// </summary>
        /// <example>MBR-df96fd60-7122-4464-b3c2-ff11d8c74f6f</example>
        [DataMember(Name = "guid", EmitDefaultValue = true)]
        public string Guid { get; set; }

        /// <summary>
        /// Gets or Sets OauthWindowUri
        /// </summary>
        /// <example>https://mxbank.mx.com/oauth/authorize?client_id&#x3D;b8OikQ4Ep3NuSUrQ13DdvFuwpNx-qqoAsJDVAQCyLkQ&amp;redirect_uri&#x3D;https%3A%2F%2Fint-app.moneydesktop.com%2Foauth%2Fredirect_from&amp;response_type&#x3D;code&amp;scope&#x3D;openid&amp;state&#x3D;d745bd4ee6f0f9c184757f574bcc2df2</example>
        [DataMember(Name = "oauth_window_uri", EmitDefaultValue = true)]
        public string OauthWindowUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuthWindowResponse {\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  OauthWindowUri: ").Append(OauthWindowUri).Append("\n");
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
            return this.Equals(input as OAuthWindowResponse);
        }

        /// <summary>
        /// Returns true if OAuthWindowResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthWindowResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthWindowResponse input)
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
                    this.OauthWindowUri == input.OauthWindowUri ||
                    (this.OauthWindowUri != null &&
                    this.OauthWindowUri.Equals(input.OauthWindowUri))
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
                if (this.OauthWindowUri != null)
                {
                    hashCode = (hashCode * 59) + this.OauthWindowUri.GetHashCode();
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

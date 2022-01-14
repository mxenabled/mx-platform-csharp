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
    /// ManagedTransactionUpdateRequest
    /// </summary>
    [DataContract(Name = "ManagedTransactionUpdateRequest")]
    public partial class ManagedTransactionUpdateRequest : IEquatable<ManagedTransactionUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedTransactionUpdateRequest" /> class.
        /// </summary>
        /// <param name="amount">amount.</param>
        /// <param name="category">category.</param>
        /// <param name="checkNumberString">checkNumberString.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="description">description.</param>
        /// <param name="id">id.</param>
        /// <param name="isInternational">isInternational.</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="localizedDescription">localizedDescription.</param>
        /// <param name="localizedMemo">localizedMemo.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="memo">memo.</param>
        /// <param name="merchantCategoryCode">merchantCategoryCode.</param>
        /// <param name="merchantGuid">merchantGuid.</param>
        /// <param name="merchantLocationGuid">merchantLocationGuid.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="postedAt">postedAt.</param>
        /// <param name="status">status.</param>
        /// <param name="transactedAt">transactedAt.</param>
        /// <param name="type">type.</param>
        public ManagedTransactionUpdateRequest(string amount = default(string), string category = default(string), string checkNumberString = default(string), string currencyCode = default(string), string description = default(string), string id = default(string), bool isInternational = default(bool), decimal latitude = default(decimal), string localizedDescription = default(string), string localizedMemo = default(string), decimal longitude = default(decimal), string memo = default(string), int merchantCategoryCode = default(int), string merchantGuid = default(string), string merchantLocationGuid = default(string), string metadata = default(string), string postedAt = default(string), string status = default(string), string transactedAt = default(string), string type = default(string))
        {
            this.Amount = amount;
            this.Category = category;
            this.CheckNumberString = checkNumberString;
            this.CurrencyCode = currencyCode;
            this.Description = description;
            this.Id = id;
            this.IsInternational = isInternational;
            this.Latitude = latitude;
            this.LocalizedDescription = localizedDescription;
            this.LocalizedMemo = localizedMemo;
            this.Longitude = longitude;
            this.Memo = memo;
            this.MerchantCategoryCode = merchantCategoryCode;
            this.MerchantGuid = merchantGuid;
            this.MerchantLocationGuid = merchantLocationGuid;
            this.Metadata = metadata;
            this.PostedAt = postedAt;
            this.Status = status;
            this.TransactedAt = transactedAt;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public string Category { get; set; }

        /// <summary>
        /// Gets or Sets CheckNumberString
        /// </summary>
        [DataMember(Name = "check_number_string", EmitDefaultValue = false)]
        public string CheckNumberString { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets IsInternational
        /// </summary>
        [DataMember(Name = "is_international", EmitDefaultValue = true)]
        public bool IsInternational { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public decimal Latitude { get; set; }

        /// <summary>
        /// Gets or Sets LocalizedDescription
        /// </summary>
        [DataMember(Name = "localized_description", EmitDefaultValue = false)]
        public string LocalizedDescription { get; set; }

        /// <summary>
        /// Gets or Sets LocalizedMemo
        /// </summary>
        [DataMember(Name = "localized_memo", EmitDefaultValue = false)]
        public string LocalizedMemo { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public decimal Longitude { get; set; }

        /// <summary>
        /// Gets or Sets Memo
        /// </summary>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or Sets MerchantCategoryCode
        /// </summary>
        [DataMember(Name = "merchant_category_code", EmitDefaultValue = false)]
        public int MerchantCategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets MerchantGuid
        /// </summary>
        [DataMember(Name = "merchant_guid", EmitDefaultValue = false)]
        public string MerchantGuid { get; set; }

        /// <summary>
        /// Gets or Sets MerchantLocationGuid
        /// </summary>
        [DataMember(Name = "merchant_location_guid", EmitDefaultValue = false)]
        public string MerchantLocationGuid { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets PostedAt
        /// </summary>
        [DataMember(Name = "posted_at", EmitDefaultValue = false)]
        public string PostedAt { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets TransactedAt
        /// </summary>
        [DataMember(Name = "transacted_at", EmitDefaultValue = false)]
        public string TransactedAt { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ManagedTransactionUpdateRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  CheckNumberString: ").Append(CheckNumberString).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsInternational: ").Append(IsInternational).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  LocalizedDescription: ").Append(LocalizedDescription).Append("\n");
            sb.Append("  LocalizedMemo: ").Append(LocalizedMemo).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
            sb.Append("  MerchantGuid: ").Append(MerchantGuid).Append("\n");
            sb.Append("  MerchantLocationGuid: ").Append(MerchantLocationGuid).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PostedAt: ").Append(PostedAt).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TransactedAt: ").Append(TransactedAt).Append("\n");
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
            return this.Equals(input as ManagedTransactionUpdateRequest);
        }

        /// <summary>
        /// Returns true if ManagedTransactionUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagedTransactionUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagedTransactionUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.CheckNumberString == input.CheckNumberString ||
                    (this.CheckNumberString != null &&
                    this.CheckNumberString.Equals(input.CheckNumberString))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsInternational == input.IsInternational ||
                    this.IsInternational.Equals(input.IsInternational)
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    this.Latitude.Equals(input.Latitude)
                ) && 
                (
                    this.LocalizedDescription == input.LocalizedDescription ||
                    (this.LocalizedDescription != null &&
                    this.LocalizedDescription.Equals(input.LocalizedDescription))
                ) && 
                (
                    this.LocalizedMemo == input.LocalizedMemo ||
                    (this.LocalizedMemo != null &&
                    this.LocalizedMemo.Equals(input.LocalizedMemo))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    this.Longitude.Equals(input.Longitude)
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
                    this.MerchantGuid == input.MerchantGuid ||
                    (this.MerchantGuid != null &&
                    this.MerchantGuid.Equals(input.MerchantGuid))
                ) && 
                (
                    this.MerchantLocationGuid == input.MerchantLocationGuid ||
                    (this.MerchantLocationGuid != null &&
                    this.MerchantLocationGuid.Equals(input.MerchantLocationGuid))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.PostedAt == input.PostedAt ||
                    (this.PostedAt != null &&
                    this.PostedAt.Equals(input.PostedAt))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TransactedAt == input.TransactedAt ||
                    (this.TransactedAt != null &&
                    this.TransactedAt.Equals(input.TransactedAt))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Category != null)
                {
                    hashCode = (hashCode * 59) + this.Category.GetHashCode();
                }
                if (this.CheckNumberString != null)
                {
                    hashCode = (hashCode * 59) + this.CheckNumberString.GetHashCode();
                }
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsInternational.GetHashCode();
                hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                if (this.LocalizedDescription != null)
                {
                    hashCode = (hashCode * 59) + this.LocalizedDescription.GetHashCode();
                }
                if (this.LocalizedMemo != null)
                {
                    hashCode = (hashCode * 59) + this.LocalizedMemo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MerchantCategoryCode.GetHashCode();
                if (this.MerchantGuid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantGuid.GetHashCode();
                }
                if (this.MerchantLocationGuid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantLocationGuid.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.PostedAt != null)
                {
                    hashCode = (hashCode * 59) + this.PostedAt.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TransactedAt != null)
                {
                    hashCode = (hashCode * 59) + this.TransactedAt.GetHashCode();
                }
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
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

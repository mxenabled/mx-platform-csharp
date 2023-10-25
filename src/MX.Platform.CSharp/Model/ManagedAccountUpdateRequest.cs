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
    /// ManagedAccountUpdateRequest
    /// </summary>
    [DataContract(Name = "ManagedAccountUpdateRequest")]
    public partial class ManagedAccountUpdateRequest : IEquatable<ManagedAccountUpdateRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManagedAccountUpdateRequest" /> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="apr">apr.</param>
        /// <param name="apy">apy.</param>
        /// <param name="availableBalance">availableBalance.</param>
        /// <param name="availableCredit">availableCredit.</param>
        /// <param name="balance">balance.</param>
        /// <param name="cashSurrenderValue">cashSurrenderValue.</param>
        /// <param name="creditLimit">creditLimit.</param>
        /// <param name="currencyCode">currencyCode.</param>
        /// <param name="dayPaymentIsDue">dayPaymentIsDue.</param>
        /// <param name="deathBenefit">deathBenefit.</param>
        /// <param name="id">id.</param>
        /// <param name="interestRate">interestRate.</param>
        /// <param name="isClosed">isClosed.</param>
        /// <param name="isHidden">isHidden.</param>
        /// <param name="lastPayment">lastPayment.</param>
        /// <param name="lastPaymentAt">lastPaymentAt.</param>
        /// <param name="loanAmount">loanAmount.</param>
        /// <param name="maturesOn">maturesOn.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="minimumBalance">minimumBalance.</param>
        /// <param name="minimumPayment">minimumPayment.</param>
        /// <param name="name">name.</param>
        /// <param name="nickname">nickname.</param>
        /// <param name="originalBalance">originalBalance.</param>
        /// <param name="paymentDueAt">paymentDueAt.</param>
        /// <param name="payoffBalance">payoffBalance.</param>
        /// <param name="routingNumber">routingNumber.</param>
        /// <param name="startedOn">startedOn.</param>
        /// <param name="subtype">subtype.</param>
        /// <param name="type">type.</param>
        public ManagedAccountUpdateRequest(string accountNumber = default(string), decimal apr = default(decimal), decimal apy = default(decimal), decimal availableBalance = default(decimal), decimal availableCredit = default(decimal), decimal balance = default(decimal), decimal cashSurrenderValue = default(decimal), decimal creditLimit = default(decimal), string currencyCode = default(string), int dayPaymentIsDue = default(int), int deathBenefit = default(int), string id = default(string), decimal interestRate = default(decimal), bool isClosed = default(bool), bool isHidden = default(bool), decimal lastPayment = default(decimal), string lastPaymentAt = default(string), decimal loanAmount = default(decimal), string maturesOn = default(string), string metadata = default(string), decimal minimumBalance = default(decimal), decimal minimumPayment = default(decimal), string name = default(string), string nickname = default(string), decimal originalBalance = default(decimal), string paymentDueAt = default(string), decimal payoffBalance = default(decimal), string routingNumber = default(string), string startedOn = default(string), string subtype = default(string), string type = default(string))
        {
            this.AccountNumber = accountNumber;
            this.Apr = apr;
            this.Apy = apy;
            this.AvailableBalance = availableBalance;
            this.AvailableCredit = availableCredit;
            this.Balance = balance;
            this.CashSurrenderValue = cashSurrenderValue;
            this.CreditLimit = creditLimit;
            this.CurrencyCode = currencyCode;
            this.DayPaymentIsDue = dayPaymentIsDue;
            this.DeathBenefit = deathBenefit;
            this.Id = id;
            this.InterestRate = interestRate;
            this.IsClosed = isClosed;
            this.IsHidden = isHidden;
            this.LastPayment = lastPayment;
            this.LastPaymentAt = lastPaymentAt;
            this.LoanAmount = loanAmount;
            this.MaturesOn = maturesOn;
            this.Metadata = metadata;
            this.MinimumBalance = minimumBalance;
            this.MinimumPayment = minimumPayment;
            this.Name = name;
            this.Nickname = nickname;
            this.OriginalBalance = originalBalance;
            this.PaymentDueAt = paymentDueAt;
            this.PayoffBalance = payoffBalance;
            this.RoutingNumber = routingNumber;
            this.StartedOn = startedOn;
            this.Subtype = subtype;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets AccountNumber
        /// </summary>
        /// <example>5366</example>
        [DataMember(Name = "account_number", EmitDefaultValue = false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Gets or Sets Apr
        /// </summary>
        /// <example>1.0</example>
        [DataMember(Name = "apr", EmitDefaultValue = false)]
        public decimal Apr { get; set; }

        /// <summary>
        /// Gets or Sets Apy
        /// </summary>
        /// <example>1.0</example>
        [DataMember(Name = "apy", EmitDefaultValue = false)]
        public decimal Apy { get; set; }

        /// <summary>
        /// Gets or Sets AvailableBalance
        /// </summary>
        /// <example>1000.0</example>
        [DataMember(Name = "available_balance", EmitDefaultValue = false)]
        public decimal AvailableBalance { get; set; }

        /// <summary>
        /// Gets or Sets AvailableCredit
        /// </summary>
        /// <example>1000.0</example>
        [DataMember(Name = "available_credit", EmitDefaultValue = false)]
        public decimal AvailableCredit { get; set; }

        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        /// <example>1000.0</example>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public decimal Balance { get; set; }

        /// <summary>
        /// Gets or Sets CashSurrenderValue
        /// </summary>
        /// <example>1000.0</example>
        [DataMember(Name = "cash_surrender_value", EmitDefaultValue = false)]
        public decimal CashSurrenderValue { get; set; }

        /// <summary>
        /// Gets or Sets CreditLimit
        /// </summary>
        /// <example>100.0</example>
        [DataMember(Name = "credit_limit", EmitDefaultValue = false)]
        public decimal CreditLimit { get; set; }

        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency_code", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Gets or Sets DayPaymentIsDue
        /// </summary>
        /// <example>20</example>
        [DataMember(Name = "day_payment_is_due", EmitDefaultValue = false)]
        public int DayPaymentIsDue { get; set; }

        /// <summary>
        /// Gets or Sets DeathBenefit
        /// </summary>
        /// <example>1000</example>
        [DataMember(Name = "death_benefit", EmitDefaultValue = false)]
        public int DeathBenefit { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /// <example>1040434698</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets InterestRate
        /// </summary>
        /// <example>1.0</example>
        [DataMember(Name = "interest_rate", EmitDefaultValue = false)]
        public decimal InterestRate { get; set; }

        /// <summary>
        /// Gets or Sets IsClosed
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "is_closed", EmitDefaultValue = true)]
        public bool IsClosed { get; set; }

        /// <summary>
        /// Gets or Sets IsHidden
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "is_hidden", EmitDefaultValue = true)]
        public bool IsHidden { get; set; }

        /// <summary>
        /// Gets or Sets LastPayment
        /// </summary>
        /// <example>100.0</example>
        [DataMember(Name = "last_payment", EmitDefaultValue = false)]
        public decimal LastPayment { get; set; }

        /// <summary>
        /// Gets or Sets LastPaymentAt
        /// </summary>
        /// <example>2015-10-13T17:57:37.000Z</example>
        [DataMember(Name = "last_payment_at", EmitDefaultValue = false)]
        public string LastPaymentAt { get; set; }

        /// <summary>
        /// Gets or Sets LoanAmount
        /// </summary>
        /// <example>1000.0</example>
        [DataMember(Name = "loan_amount", EmitDefaultValue = false)]
        public decimal LoanAmount { get; set; }

        /// <summary>
        /// Gets or Sets MaturesOn
        /// </summary>
        /// <example>2015-10-13T17:57:37.000Z</example>
        [DataMember(Name = "matures_on", EmitDefaultValue = false)]
        public string MaturesOn { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        /// <example>some metadata</example>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public string Metadata { get; set; }

        /// <summary>
        /// Gets or Sets MinimumBalance
        /// </summary>
        /// <example>100.0</example>
        [DataMember(Name = "minimum_balance", EmitDefaultValue = false)]
        public decimal MinimumBalance { get; set; }

        /// <summary>
        /// Gets or Sets MinimumPayment
        /// </summary>
        /// <example>10.0</example>
        [DataMember(Name = "minimum_payment", EmitDefaultValue = false)]
        public decimal MinimumPayment { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Test account 2</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Nickname
        /// </summary>
        /// <example>Swiss Account</example>
        [DataMember(Name = "nickname", EmitDefaultValue = false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or Sets OriginalBalance
        /// </summary>
        /// <example>10.0</example>
        [DataMember(Name = "original_balance", EmitDefaultValue = false)]
        public decimal OriginalBalance { get; set; }

        /// <summary>
        /// Gets or Sets PaymentDueAt
        /// </summary>
        /// <example>2015-10-13T17:57:37.000Z</example>
        [DataMember(Name = "payment_due_at", EmitDefaultValue = false)]
        public string PaymentDueAt { get; set; }

        /// <summary>
        /// Gets or Sets PayoffBalance
        /// </summary>
        /// <example>10.0</example>
        [DataMember(Name = "payoff_balance", EmitDefaultValue = false)]
        public decimal PayoffBalance { get; set; }

        /// <summary>
        /// Gets or Sets RoutingNumber
        /// </summary>
        /// <example>68899990000000</example>
        [DataMember(Name = "routing_number", EmitDefaultValue = false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Gets or Sets StartedOn
        /// </summary>
        /// <example>2015-10-13T17:57:37.000Z</example>
        [DataMember(Name = "started_on", EmitDefaultValue = false)]
        public string StartedOn { get; set; }

        /// <summary>
        /// Gets or Sets Subtype
        /// </summary>
        /// <example>NONE</example>
        [DataMember(Name = "subtype", EmitDefaultValue = false)]
        public string Subtype { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        /// <example>SAVINGS</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ManagedAccountUpdateRequest {\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Apr: ").Append(Apr).Append("\n");
            sb.Append("  Apy: ").Append(Apy).Append("\n");
            sb.Append("  AvailableBalance: ").Append(AvailableBalance).Append("\n");
            sb.Append("  AvailableCredit: ").Append(AvailableCredit).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  CashSurrenderValue: ").Append(CashSurrenderValue).Append("\n");
            sb.Append("  CreditLimit: ").Append(CreditLimit).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  DayPaymentIsDue: ").Append(DayPaymentIsDue).Append("\n");
            sb.Append("  DeathBenefit: ").Append(DeathBenefit).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
            sb.Append("  IsClosed: ").Append(IsClosed).Append("\n");
            sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
            sb.Append("  LastPayment: ").Append(LastPayment).Append("\n");
            sb.Append("  LastPaymentAt: ").Append(LastPaymentAt).Append("\n");
            sb.Append("  LoanAmount: ").Append(LoanAmount).Append("\n");
            sb.Append("  MaturesOn: ").Append(MaturesOn).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  MinimumBalance: ").Append(MinimumBalance).Append("\n");
            sb.Append("  MinimumPayment: ").Append(MinimumPayment).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  OriginalBalance: ").Append(OriginalBalance).Append("\n");
            sb.Append("  PaymentDueAt: ").Append(PaymentDueAt).Append("\n");
            sb.Append("  PayoffBalance: ").Append(PayoffBalance).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  StartedOn: ").Append(StartedOn).Append("\n");
            sb.Append("  Subtype: ").Append(Subtype).Append("\n");
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
            return this.Equals(input as ManagedAccountUpdateRequest);
        }

        /// <summary>
        /// Returns true if ManagedAccountUpdateRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ManagedAccountUpdateRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManagedAccountUpdateRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.Apr == input.Apr ||
                    this.Apr.Equals(input.Apr)
                ) && 
                (
                    this.Apy == input.Apy ||
                    this.Apy.Equals(input.Apy)
                ) && 
                (
                    this.AvailableBalance == input.AvailableBalance ||
                    this.AvailableBalance.Equals(input.AvailableBalance)
                ) && 
                (
                    this.AvailableCredit == input.AvailableCredit ||
                    this.AvailableCredit.Equals(input.AvailableCredit)
                ) && 
                (
                    this.Balance == input.Balance ||
                    this.Balance.Equals(input.Balance)
                ) && 
                (
                    this.CashSurrenderValue == input.CashSurrenderValue ||
                    this.CashSurrenderValue.Equals(input.CashSurrenderValue)
                ) && 
                (
                    this.CreditLimit == input.CreditLimit ||
                    this.CreditLimit.Equals(input.CreditLimit)
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    (this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(input.CurrencyCode))
                ) && 
                (
                    this.DayPaymentIsDue == input.DayPaymentIsDue ||
                    this.DayPaymentIsDue.Equals(input.DayPaymentIsDue)
                ) && 
                (
                    this.DeathBenefit == input.DeathBenefit ||
                    this.DeathBenefit.Equals(input.DeathBenefit)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InterestRate == input.InterestRate ||
                    this.InterestRate.Equals(input.InterestRate)
                ) && 
                (
                    this.IsClosed == input.IsClosed ||
                    this.IsClosed.Equals(input.IsClosed)
                ) && 
                (
                    this.IsHidden == input.IsHidden ||
                    this.IsHidden.Equals(input.IsHidden)
                ) && 
                (
                    this.LastPayment == input.LastPayment ||
                    this.LastPayment.Equals(input.LastPayment)
                ) && 
                (
                    this.LastPaymentAt == input.LastPaymentAt ||
                    (this.LastPaymentAt != null &&
                    this.LastPaymentAt.Equals(input.LastPaymentAt))
                ) && 
                (
                    this.LoanAmount == input.LoanAmount ||
                    this.LoanAmount.Equals(input.LoanAmount)
                ) && 
                (
                    this.MaturesOn == input.MaturesOn ||
                    (this.MaturesOn != null &&
                    this.MaturesOn.Equals(input.MaturesOn))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.MinimumBalance == input.MinimumBalance ||
                    this.MinimumBalance.Equals(input.MinimumBalance)
                ) && 
                (
                    this.MinimumPayment == input.MinimumPayment ||
                    this.MinimumPayment.Equals(input.MinimumPayment)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Nickname == input.Nickname ||
                    (this.Nickname != null &&
                    this.Nickname.Equals(input.Nickname))
                ) && 
                (
                    this.OriginalBalance == input.OriginalBalance ||
                    this.OriginalBalance.Equals(input.OriginalBalance)
                ) && 
                (
                    this.PaymentDueAt == input.PaymentDueAt ||
                    (this.PaymentDueAt != null &&
                    this.PaymentDueAt.Equals(input.PaymentDueAt))
                ) && 
                (
                    this.PayoffBalance == input.PayoffBalance ||
                    this.PayoffBalance.Equals(input.PayoffBalance)
                ) && 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
                ) && 
                (
                    this.StartedOn == input.StartedOn ||
                    (this.StartedOn != null &&
                    this.StartedOn.Equals(input.StartedOn))
                ) && 
                (
                    this.Subtype == input.Subtype ||
                    (this.Subtype != null &&
                    this.Subtype.Equals(input.Subtype))
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
                if (this.AccountNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Apr.GetHashCode();
                hashCode = (hashCode * 59) + this.Apy.GetHashCode();
                hashCode = (hashCode * 59) + this.AvailableBalance.GetHashCode();
                hashCode = (hashCode * 59) + this.AvailableCredit.GetHashCode();
                hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                hashCode = (hashCode * 59) + this.CashSurrenderValue.GetHashCode();
                hashCode = (hashCode * 59) + this.CreditLimit.GetHashCode();
                if (this.CurrencyCode != null)
                {
                    hashCode = (hashCode * 59) + this.CurrencyCode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DayPaymentIsDue.GetHashCode();
                hashCode = (hashCode * 59) + this.DeathBenefit.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InterestRate.GetHashCode();
                hashCode = (hashCode * 59) + this.IsClosed.GetHashCode();
                hashCode = (hashCode * 59) + this.IsHidden.GetHashCode();
                hashCode = (hashCode * 59) + this.LastPayment.GetHashCode();
                if (this.LastPaymentAt != null)
                {
                    hashCode = (hashCode * 59) + this.LastPaymentAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LoanAmount.GetHashCode();
                if (this.MaturesOn != null)
                {
                    hashCode = (hashCode * 59) + this.MaturesOn.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MinimumBalance.GetHashCode();
                hashCode = (hashCode * 59) + this.MinimumPayment.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Nickname != null)
                {
                    hashCode = (hashCode * 59) + this.Nickname.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OriginalBalance.GetHashCode();
                if (this.PaymentDueAt != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentDueAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PayoffBalance.GetHashCode();
                if (this.RoutingNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RoutingNumber.GetHashCode();
                }
                if (this.StartedOn != null)
                {
                    hashCode = (hashCode * 59) + this.StartedOn.GetHashCode();
                }
                if (this.Subtype != null)
                {
                    hashCode = (hashCode * 59) + this.Subtype.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

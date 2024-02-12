﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CustomerAccount4.  ISO2002 ID# _1qi_0Q1ZEeKGXqvMN6jpiw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Account owned by a customer.
/// </summary>
[IsoId("_1qi_0Q1ZEeKGXqvMN6jpiw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Customer Account")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustomerAccount4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustomerAccount4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustomerAccount4( string reqCurrency )
    {
        Currency = reqCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the account.
    /// </summary>
    [IsoId("_2ATNYQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountIdentification4Choice_? Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountIdentification4Choice_? Identification { get; init; } 
    #else
    public AccountIdentification4Choice_? Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Name of the account. It provides an additional means of identification, and is designated by the account servicer in agreement with the account owner.
    /// </summary>
    [IsoId("_2ATNZQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Name")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax70Text? Name { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Name { get; init; } 
    #else
    public System.String? Name { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the current state of an account, eg, enabled or deleted.
    /// </summary>
    [IsoId("_2ATNaQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountStatus3Code? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountStatus3Code? Status { get; init; } 
    #else
    public AccountStatus3Code? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Type of the account.
    /// </summary>
    [IsoId("_2ATNbQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccountType2Choice_? Type { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccountType2Choice_? Type { get; init; } 
    #else
    public CashAccountType2Choice_? Type { get; set; } 
    #endif
    
    /// <summary>
    /// Medium of exchange of value.
    /// </summary>
    [IsoId("_2ATNcQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Monthly average of the payment amounts (that is, payments going out) over a year.
    /// </summary>
    [IsoId("_2ATNdQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Monthly Payment Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? MonthlyPaymentValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MonthlyPaymentValue { get; init; } 
    #else
    public System.Decimal? MonthlyPaymentValue { get; set; } 
    #endif
    
    /// <summary>
    /// Monthly average of the received amounts over a year (that is, payments coming in).
    /// </summary>
    [IsoId("_2ATNeQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Monthly Received Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? MonthlyReceivedValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MonthlyReceivedValue { get; init; } 
    #else
    public System.Decimal? MonthlyReceivedValue { get; set; } 
    #endif
    
    /// <summary>
    /// Monthly average of the number of payments (coming in and going out) over a year.
    /// </summary>
    [IsoId("_2ATNfQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Monthly Transaction Number")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax5NumericText? MonthlyTransactionNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MonthlyTransactionNumber { get; init; } 
    #else
    public System.String? MonthlyTransactionNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Sum of the end of day balances over a month divided by the number of business days in the month.
    /// </summary>
    [IsoId("_2ATNgQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Average Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? AverageBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AverageBalance { get; init; } 
    #else
    public System.Decimal? AverageBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the purpose of the account.
    /// </summary>
    [IsoId("_2ATNhQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Purpose")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AccountPurpose { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AccountPurpose { get; init; } 
    #else
    public System.String? AccountPurpose { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value of the balance under which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_2ATNiQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Floor Notification Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? FloorNotificationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? FloorNotificationAmount { get; init; } 
    #else
    public System.Decimal? FloorNotificationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the value of the balance above which a notification will be sent to the account owner.
    /// </summary>
    [IsoId("_2ATNjQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Ceiling Notification Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? CeilingNotificationAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CeilingNotificationAmount { get; init; } 
    #else
    public System.Decimal? CeilingNotificationAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies how often statements (for audit purposes) will be sent, in which format, to which address.
    /// </summary>
    [IsoId("_2ATNkQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Statement Frequency And Format")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatementFrequencyAndForm1? StatementFrequencyAndFormat { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatementFrequencyAndForm1? StatementFrequencyAndFormat { get; init; } 
    #else
    public StatementFrequencyAndForm1? StatementFrequencyAndFormat { get; set; } 
    #endif
    
    /// <summary>
    /// Date when the account will be or was closed.
    /// </summary>
    [IsoId("_2ATNlQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Closing Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ClosingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ClosingDate { get; init; } 
    #else
    public System.DateOnly? ClosingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Restriction on capability or operations allowed.
    /// </summary>
    [IsoId("_2ATNmQ1ZEeKGXqvMN6jpiw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Restriction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Restriction1? Restriction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Restriction1? Restriction { get; init; } 
    #else
    public Restriction1? Restriction { get; set; } 
    #endif
    
    
    #nullable disable
    
}

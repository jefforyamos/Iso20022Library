﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails15.  ISO2002 ID# _CsdvcTJ9EeOqyZqt0rCZLg.
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
/// Details of the transaction to capture.
/// </summary>
[IsoId("_CsdvcTJ9EeOqyZqt0rCZLg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Payment Transaction Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransactionDetails15
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransactionDetails15 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransactionDetails15( System.Decimal reqTotalAmount )
    {
        TotalAmount = reqTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_C7oz4TJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_C7oz4zJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoImpliedCurrencyAndAmount TotalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal TotalAmount { get; init; } 
    #else
    public System.Decimal TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_C7oz5TJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount Qualifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfAmount1Code? AmountQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount1Code? AmountQualifier { get; init; } 
    #else
    public TypeOfAmount1Code? AmountQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_C7oz5zJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Detailed Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount5? DetailedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount5? DetailedAmount { get; init; } 
    #else
    public DetailedAmount5? DetailedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    [IsoId("_Vsr4EDJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Requested Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? RequestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? RequestedAmount { get; init; } 
    #else
    public System.Decimal? RequestedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount authorised for the transaction.
    /// </summary>
    [IsoId("_ao-y8DJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Authorised Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? AuthorisedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? AuthorisedAmount { get; init; } 
    #else
    public System.Decimal? AuthorisedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_C7oz6TJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Validity Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ValidityDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ValidityDate { get; init; } 
    #else
    public System.DateOnly? ValidityDate { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_C7oz6zJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unattended Level Category")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 0 ,MinimumLength = 0)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? UnattendedLevelCategory { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? UnattendedLevelCategory { get; init; } 
    #else
    public System.String? UnattendedLevelCategory { get; set; } 
    #endif
    
    /// <summary>
    /// Type of cardholder account used for the transaction.
    /// </summary>
    [IsoId("_C7oz7TJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccountType1Code? AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccountType1Code? AccountType { get; init; } 
    #else
    public CardAccountType1Code? AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates if the currency conversion has been accepted by the cardholder.
    /// </summary>
    [IsoId("_uZtLcDJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Conversion Accepted")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoTrueFalseIndicator? ConversionAccepted { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ConversionAccepted { get; init; } 
    #else
    public System.String? ConversionAccepted { get; set; } 
    #endif
    
    /// <summary>
    /// Currency conversion proposed to the cardholder.
    /// </summary>
    [IsoId("_kRSNIDKBEeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency Conversion")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion1? CurrencyConversion { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion1? CurrencyConversion { get; init; } 
    #else
    public CurrencyConversion1? CurrencyConversion { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_u6-IoDKBEeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instalment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RecurringTransaction2? Instalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RecurringTransaction2? Instalment { get; init; } 
    #else
    public RecurringTransaction2? Instalment { get; set; } 
    #endif
    
    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    [IsoId("_9gqmsDKBEeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Aggregation Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregationTransaction1? AggregationTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregationTransaction1? AggregationTransaction { get; init; } 
    #else
    public AggregationTransaction1? AggregationTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Product purchased with the transaction.
    /// </summary>
    [IsoId("_C7oz8TJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Product")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Product1? Product { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product1? Product { get; init; } 
    #else
    public Product1? Product { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed invoice data.
    /// </summary>
    [IsoId("_DTaocDKCEeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Card Payment Invoice")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentInvoice1? CardPaymentInvoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentInvoice1? CardPaymentInvoice { get; init; } 
    #else
    public CardPaymentInvoice1? CardPaymentInvoice { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_C7oz8zJ9EeOqyZqt0rCZLg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("ICC Related Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Byte[]? ICCRelatedData { get; init; } 
    #else
    public System.Byte[]? ICCRelatedData { get; set; } 
    #endif
    
    
    #nullable disable
    
}

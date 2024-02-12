﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentTransactionDetails51.  ISO2002 ID# _VQERgU3cEey_VecAUE-C9Q.
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
/// Details of the transaction in the authorisation request in a batch.
/// </summary>
[IsoId("_VQERgU3cEey_VecAUE-C9Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Payment Transaction Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentTransactionDetails51
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentTransactionDetails51 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentTransactionDetails51( System.Decimal reqTotalAmount )
    {
        TotalAmount = reqTotalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency associated with the transaction.
    /// </summary>
    [IsoId("_VXIi0U3cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveCurrencyCode? Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? Currency { get; init; } 
    #else
    public string? Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount of the transaction.
    /// </summary>
    [IsoId("_VXIi003cEey_VecAUE-C9Q")]
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
    /// Contains the updated amount of all authorisations related to the same business transaction.
    /// </summary>
    [IsoId("_VXIi1U3cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cumulative Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? CumulativeAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? CumulativeAmount { get; init; } 
    #else
    public System.Decimal? CumulativeAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Qualifies the amount associated with the transaction.
    /// </summary>
    [IsoId("_VXIi103cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount Qualifier")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TypeOfAmount8Code? AmountQualifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TypeOfAmount8Code? AmountQualifier { get; init; } 
    #else
    public TypeOfAmount8Code? AmountQualifier { get; set; } 
    #endif
    
    /// <summary>
    /// Detailed amounts associated with the total amount of transaction.
    /// </summary>
    [IsoId("_VXIi2U3cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Detailed Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DetailedAmount15? DetailedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DetailedAmount15? DetailedAmount { get; init; } 
    #else
    public DetailedAmount15? DetailedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Amount requested to be authorised.
    /// </summary>
    [IsoId("_VXIi203cEey_VecAUE-C9Q")]
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
    /// Amount authorised for the payment transaction.
    /// </summary>
    [IsoId("_VXIi3U3cEey_VecAUE-C9Q")]
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
    /// Amount of the transaction that will be invoiced to the cardholder.
    /// </summary>
    [IsoId("_VXIi303cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Invoice Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? InvoiceAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InvoiceAmount { get; init; } 
    #else
    public System.Decimal? InvoiceAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction authorisation deadline to complete the related payment.
    /// </summary>
    [IsoId("_VXIi4U3cEey_VecAUE-C9Q")]
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
    /// Reason to process an online authorisation.
    /// </summary>
    [IsoId("_VXIi403cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("On Line Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OnLineReason2Code? OnLineReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OnLineReason2Code? OnLineReason { get; init; } 
    #else
    public OnLineReason2Code? OnLineReason { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction category level on an unattended POI (Point Of Interaction).
    /// </summary>
    [IsoId("_VXIi5U3cEey_VecAUE-C9Q")]
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
    [IsoId("_VXIi503cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardAccountType3Code? AccountType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardAccountType3Code? AccountType { get; init; } 
    #else
    public CardAccountType3Code? AccountType { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the currency conversion proposed to the cardholder.
    /// </summary>
    [IsoId("_VXIi6U3cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency Conversion Result")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion24? CurrencyConversionResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion24? CurrencyConversionResult { get; init; } 
    #else
    public CurrencyConversion24? CurrencyConversionResult { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a financial loan (instalment) or to a recurring transaction.
    /// </summary>
    [IsoId("_VXIi603cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Instalment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RecurringTransaction4? Instalment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RecurringTransaction4? Instalment { get; init; } 
    #else
    public RecurringTransaction4? Instalment { get; set; } 
    #endif
    
    /// <summary>
    /// Payment transaction with an aggregated amount.
    /// </summary>
    [IsoId("_VXIi7U3cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Aggregation Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AggregationTransaction3? AggregationTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AggregationTransaction3? AggregationTransaction { get; init; } 
    #else
    public AggregationTransaction3? AggregationTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Codification used to identify the products.
    /// </summary>
    [IsoId("_VXIi703cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Product Code Set Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? ProductCodeSetIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ProductCodeSetIdentification { get; init; } 
    #else
    public System.String? ProductCodeSetIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Item purchased with the transaction.
    /// </summary>
    [IsoId("_VXIi8U3cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sale Item")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Product6? SaleItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Product6? SaleItem { get; init; } 
    #else
    public Product6? SaleItem { get; set; } 
    #endif
    
    /// <summary>
    /// Location of the delivery, for instance pump number or parking bay.
    /// </summary>
    [IsoId("_VXIi803cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Delivery Location")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? DeliveryLocation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? DeliveryLocation { get; init; } 
    #else
    public System.String? DeliveryLocation { get; set; } 
    #endif
    
    /// <summary>
    /// In case a message is sent after the consumption of goods or service, it indicates the number of times the authorisation has been sent to the Acquirer in order to get an approval.
    /// </summary>
    [IsoId("_s7SGkE7BEeyGi9JAv6wq7Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Re Submission Counter")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPositiveNumber? ReSubmissionCounter { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? ReSubmissionCounter { get; init; } 
    #else
    public System.UInt64? ReSubmissionCounter { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information related to the transaction like an Invoice or IndustryData (for example  hospitality, lodging, transportation).
    /// </summary>
    [IsoId("_VXIi9U3cEey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExternallyDefinedData3? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExternallyDefinedData3? AdditionalInformation { get; init; } 
    #else
    public ExternallyDefinedData3? AdditionalInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to an integrated circuit card application.
    /// </summary>
    [IsoId("_VXIi903cEey_VecAUE-C9Q")]
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

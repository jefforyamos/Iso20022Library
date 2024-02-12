﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyConversion23.  ISO2002 ID# _n3pl4VE4EeyApZmLzm74zA.
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
/// Conversion between the currency of a card acceptor and the currency of a card issuer, provided by a dedicated service provider. The currency conversion has to be accepted by the cardholder.
/// </summary>
[IsoId("_n3pl4VE4EeyApZmLzm74zA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Currency Conversion")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyConversion23
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyConversion23 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyConversion23( CurrencyDetails3 reqTargetCurrency,System.Decimal reqResultingAmount,System.Decimal reqExchangeRate,CurrencyDetails2 reqSourceCurrency,OriginalAmountDetails1 reqOriginalAmount )
    {
        TargetCurrency = reqTargetCurrency;
        ResultingAmount = reqResultingAmount;
        ExchangeRate = reqExchangeRate;
        SourceCurrency = reqSourceCurrency;
        OriginalAmount = reqOriginalAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the currency conversion operation for the service provider.
    /// </summary>
    [IsoId("_n9-QUVE4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency Conversion Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CurrencyConversionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CurrencyConversionIdentification { get; init; } 
    #else
    public System.String? CurrencyConversionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Currency into which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_n9-QU1E4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Target Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyDetails3 TargetCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CurrencyDetails3 TargetCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyDetails3 TargetCurrency { get; init; } 
    #else
    public CurrencyDetails3 TargetCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Amount converted in the target currency, including additional charges.
    /// </summary>
    [IsoId("_n9-QVVE4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Resulting Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoImpliedCurrencyAndAmount ResultingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal ResultingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ResultingAmount { get; init; } 
    #else
    public System.Decimal ResultingAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the original amount into the resulting amount.
    /// </summary>
    [IsoId("_n9-QV1E4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exchange Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate ExchangeRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ExchangeRate { get; init; } 
    #else
    public System.Decimal ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate, expressed as a percentage, applied to convert the resulting amount into the original amount.
    /// </summary>
    [IsoId("_n9-QWVE4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Inverted Exchange Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? InvertedExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? InvertedExchangeRate { get; init; } 
    #else
    public System.Decimal? InvertedExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the exchange rate has been quoted.
    /// </summary>
    [IsoId("_n9-QW1E4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quotation Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? QuotationDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? QuotationDate { get; init; } 
    #else
    public System.DateTime? QuotationDate { get; set; } 
    #endif
    
    /// <summary>
    /// Validity limit of the exchange rate.
    /// </summary>
    [IsoId("_n9-QXVE4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Valid Until")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? ValidUntil { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? ValidUntil { get; init; } 
    #else
    public System.DateTime? ValidUntil { get; set; } 
    #endif
    
    /// <summary>
    /// Currency from which the amount is converted (ISO 4217, 3 alphanumeric characters).
    /// </summary>
    [IsoId("_n9-QX1E4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Source Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyDetails2 SourceCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CurrencyDetails2 SourceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyDetails2 SourceCurrency { get; init; } 
    #else
    public CurrencyDetails2 SourceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Original amount in the source currency.
    /// </summary>
    [IsoId("_n9-QYVE4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalAmountDetails1 OriginalAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public OriginalAmountDetails1 OriginalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalAmountDetails1 OriginalAmount { get; init; } 
    #else
    public OriginalAmountDetails1 OriginalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Commission or additional charges made as part of a currency conversion.
    /// </summary>
    [IsoId("_n9-QY1E4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Commission Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission19? CommissionDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission19? CommissionDetails { get; init; } 
    #else
    public Commission19? CommissionDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Markup made as part of a currency conversion.
    /// </summary>
    [IsoId("_n9-QZVE4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Mark Up Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Commission18? MarkUpDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Commission18? MarkUpDetails { get; init; } 
    #else
    public Commission18? MarkUpDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Card scheme declaration (disclaimer) to present to the cardholder.
    /// </summary>
    [IsoId("_n9-QZ1E4EeyApZmLzm74zA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Declaration Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActionMessage9? DeclarationDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActionMessage9? DeclarationDetails { get; init; } 
    #else
    public ActionMessage9? DeclarationDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}

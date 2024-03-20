﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ForeignExchangeTerms8.  ISO2002 ID# _QLzlZtp-Ed-ak6NoX_4Aeg_-244208609.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Provides information about the terms of the foreign exchange transaction.
/// </summary>
[IsoId("_QLzlZtp-Ed-ak6NoX_4Aeg_-244208609")]
[DisplayName("Foreign Exchange Terms")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ForeignExchangeTerms8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ForeignExchangeTerms8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ForeignExchangeTerms8( string reqUnitCurrency,string reqQuotedCurrency,System.Decimal reqExchangeRate,ActiveCurrencyAndAmount reqResultingAmount )
    {
        UnitCurrency = reqUnitCurrency;
        QuotedCurrency = reqQuotedCurrency;
        ExchangeRate = reqExchangeRate;
        ResultingAmount = reqResultingAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency in which the rate of exchange is expressed in a currency exchange. In the example 1GBP = xxxCUR, the unit currency is GBP.
    /// </summary>
    [IsoId("_QLzlZ9p-Ed-ak6NoX_4Aeg_157524165")]
    [DisplayName("Unit Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="UnitCcy")]
    #endif
    [IsoXmlTag("UnitCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode UnitCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string UnitCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string UnitCurrency { get; init; } 
    #else
    public string UnitCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency into which the base currency is converted, in a currency exchange.
    /// </summary>
    [IsoId("_QL9WYNp-Ed-ak6NoX_4Aeg_157524196")]
    [DisplayName("Quoted Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtdCcy")]
    #endif
    [IsoXmlTag("QtdCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode QuotedCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string QuotedCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string QuotedCurrency { get; init; } 
    #else
    public string QuotedCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used for the conversion of an amount from one currency into another. This reflects the price at which one currency was bought with another currency.||Usage: ExchangeRate expresses the ratio between UnitCurrency and QuotedCurrency (ExchangeRate = UnitCurrency/QuotedCurrency).
    /// </summary>
    [IsoId("_QL9WYdp-Ed-ak6NoX_4Aeg_157524226")]
    [DisplayName("Exchange Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="XchgRate")]
    #endif
    [IsoXmlTag("XchgRate")]
    [IsoSimpleType(IsoSimpleType.BaseOneRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ExchangeRate { get; init; } 
    #else
    public System.Decimal ExchangeRate { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money resulting from a foreign exchange transaction.
    /// </summary>
    [IsoId("_QL9WYtp-Ed-ak6NoX_4Aeg_-176260697")]
    [DisplayName("Resulting Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsltgAmt")]
    #endif
    [IsoXmlTag("RsltgAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyAndAmount ResultingAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ActiveCurrencyAndAmount ResultingAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ActiveCurrencyAndAmount ResultingAmount { get; init; } 
    #else
    public ActiveCurrencyAndAmount ResultingAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}

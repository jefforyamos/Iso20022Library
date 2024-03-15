﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ActiveOrHistoricCurrencyAndAmountRange2.  ISO2002 ID# _PPV2V5lcEeeE1Ya-LgRsuQ.
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
/// Range of amount values.
/// </summary>
[IsoId("_PPV2V5lcEeeE1Ya-LgRsuQ")]
[DisplayName("Active Or Historic Currency And Amount Range")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ActiveOrHistoricCurrencyAndAmountRange2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ActiveOrHistoricCurrencyAndAmountRange2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ActiveOrHistoricCurrencyAndAmountRange2( ImpliedCurrencyAmountRange1Choice_ reqAmount,string reqCurrency )
    {
        Amount = reqAmount;
        Currency = reqCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specified amount or amount range.
    /// </summary>
    [IsoId("_PXu9U5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ImpliedCurrencyAmountRange1Choice_ Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ImpliedCurrencyAmountRange1Choice_ Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ImpliedCurrencyAmountRange1Choice_ Amount { get; init; } 
    #else
    public ImpliedCurrencyAmountRange1Choice_ Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the amount is a credited or debited amount.
    /// </summary>
    [IsoId("_PXu9VZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Credit Debit Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtDbtInd")]
    #endif
    [IsoXmlTag("CdtDbtInd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditDebitCode? CreditDebitIndicator { get; init; } 
    #else
    public CreditDebitCode? CreditDebitIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Medium of exchange of value, used to qualify an amount.
    /// </summary>
    [IsoId("_PXu9V5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ccy")]
    #endif
    [IsoXmlTag("Ccy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    
    #nullable disable
    
}

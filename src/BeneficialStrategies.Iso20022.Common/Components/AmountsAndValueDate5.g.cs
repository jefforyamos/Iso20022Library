﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AmountsAndValueDate5.  ISO2002 ID# _TIwetNp-Ed-ak6NoX_4Aeg_-974658214.
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
/// Specifies the value date and the amounts traded in a foreign exchange option trade.
/// </summary>
[IsoId("_TIwetNp-Ed-ak6NoX_4Aeg_-974658214")]
[DisplayName("Amounts And Value Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AmountsAndValueDate5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AmountsAndValueDate5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AmountsAndValueDate5( System.Decimal reqCallAmount,System.Decimal reqPutAmount )
    {
        CallAmount = reqCallAmount;
        PutAmount = reqPutAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Call amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TIwetdp-Ed-ak6NoX_4Aeg_-974658188")]
    [DisplayName("Call Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CallAmt")]
    #endif
    [IsoXmlTag("CallAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveOrHistoricCurrencyAndAmount CallAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal CallAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal CallAmount { get; init; } 
    #else
    public System.Decimal CallAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Put amount and currency of a foreign exchange option trade.
    /// </summary>
    [IsoId("_TIwettp-Ed-ak6NoX_4Aeg_-974658137")]
    [DisplayName("Put Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PutAmt")]
    #endif
    [IsoXmlTag("PutAmt")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveOrHistoricCurrencyAndAmount PutAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal PutAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal PutAmount { get; init; } 
    #else
    public System.Decimal PutAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Agreement between two parties in which one party buys a currency and the other party sells a different currency.
    /// </summary>
    [IsoId("_TIwet9p-Ed-ak6NoX_4Aeg_-831511638")]
    [DisplayName("Option Settlement Currency")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OptnSttlmCcy")]
    #endif
    [IsoXmlTag("OptnSttlmCcy")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ActiveOrHistoricCurrencyCode? OptionSettlementCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string? OptionSettlementCurrency { get; init; } 
    #else
    public string? OptionSettlementCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which the trade is settled, ie, the amounts are due.
    /// </summary>
    [IsoId("_TIweuNp-Ed-ak6NoX_4Aeg_-974658172")]
    [DisplayName("Final Settlement Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FnlSttlmDt")]
    #endif
    [IsoXmlTag("FnlSttlmDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? FinalSettlementDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? FinalSettlementDate { get; init; } 
    #else
    public System.DateOnly? FinalSettlementDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}

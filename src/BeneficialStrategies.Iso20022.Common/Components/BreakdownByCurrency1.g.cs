﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for BreakdownByCurrency1.  ISO2002 ID# _RQDQodp-Ed-ak6NoX_4Aeg_1062807624.
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
/// Specifies the cash-in and cash-out flows by currency.
/// </summary>
[IsoId("_RQDQodp-Ed-ak6NoX_4Aeg_1062807624")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Breakdown By Currency")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BreakdownByCurrency1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BreakdownByCurrency1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BreakdownByCurrency1( string reqCurrency )
    {
        Currency = reqCurrency;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency for which the cash flow is being reported.
    /// </summary>
    [IsoId("_RQDQotp-Ed-ak6NoX_4Aeg_-1284357393")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveOrHistoricCurrencyCode Currency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public string Currency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string Currency { get; init; } 
    #else
    public string Currency { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movement out of the fund as a result of investment funds transactions, eg, redemptions or switch-out.
    /// </summary>
    [IsoId("_RQDQo9p-Ed-ak6NoX_4Aeg_1062808443")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Out Forecast")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashOutForecast3? CashOutForecast { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashOutForecast3? CashOutForecast { get; init; } 
    #else
    public CashOutForecast3? CashOutForecast { get; set; } 
    #endif
    
    /// <summary>
    /// Cash movement into the fund as a result of investment funds transactions, eg, subscriptions or switch-in.
    /// </summary>
    [IsoId("_RQDQpNp-Ed-ak6NoX_4Aeg_1062808015")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash In Forecast")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashInForecast3? CashInForecast { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashInForecast3? CashInForecast { get; init; } 
    #else
    public CashInForecast3? CashInForecast { get; set; } 
    #endif
    
    /// <summary>
    /// Net cash as a result of the cash-in and cash-out flows specified for the currency.
    /// </summary>
    [IsoId("_RQDQpdp-Ed-ak6NoX_4Aeg_1062807703")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Net Cash Forecast")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NetCashForecast2? NetCashForecast { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NetCashForecast2? NetCashForecast { get; init; } 
    #else
    public NetCashForecast2? NetCashForecast { get; set; } 
    #endif
    
    
    #nullable disable
    
}

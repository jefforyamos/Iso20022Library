﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyExchange16.  ISO2002 ID# _XaGizfWfEemtd4wHZYvFUQ.
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
/// Describes the details of the currency exchange.
/// </summary>
[IsoId("_XaGizfWfEemtd4wHZYvFUQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Currency Exchange")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CurrencyExchange16
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CurrencyExchange16 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CurrencyExchange16( string reqSourceCurrency,string reqTargetCurrency,System.Decimal reqExchangeRate )
    {
        SourceCurrency = reqSourceCurrency;
        TargetCurrency = reqTargetCurrency;
        ExchangeRate = reqExchangeRate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Currency from which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_XaGiz_WfEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Source Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode SourceCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public string SourceCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string SourceCurrency { get; init; } 
    #else
    public string SourceCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Currency into which an amount is to be converted in a currency conversion.
    /// </summary>
    [IsoId("_XaGi0fWfEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Target Currency")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ActiveCurrencyCode TargetCurrency { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public string TargetCurrency { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public string TargetCurrency { get; init; } 
    #else
    public string TargetCurrency { get; set; } 
    #endif
    
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    [IsoId("_XaGi0_WfEemtd4wHZYvFUQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Exchange Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoBaseOneRate ExchangeRate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal ExchangeRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal ExchangeRate { get; init; } 
    #else
    public System.Decimal ExchangeRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}

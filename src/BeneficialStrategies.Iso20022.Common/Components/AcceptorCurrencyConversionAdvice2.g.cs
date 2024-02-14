﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCurrencyConversionAdvice2.  ISO2002 ID# _UAtD0dtYEee9e6xduATmQg.
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
/// Information related to the currency conversion advice.
/// </summary>
[IsoId("_UAtD0dtYEee9e6xduATmQg")]
[DisplayName("Acceptor Currency Conversion Advice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorCurrencyConversionAdvice2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorCurrencyConversionAdvice2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorCurrencyConversionAdvice2( CardPaymentEnvironment69 reqEnvironment,CardPaymentTransaction77 reqTransaction )
    {
        Environment = reqEnvironment;
        Transaction = reqTransaction;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("_UJxgQdtYEee9e6xduATmQg")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment69 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment69 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment69 Environment { get; init; } 
    #else
    public CardPaymentEnvironment69 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and a currency conversion provider.
    /// </summary>
    [IsoId("_UJxgQ9tYEee9e6xduATmQg")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransaction77 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentTransaction77 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction77 Transaction { get; init; } 
    #else
    public CardPaymentTransaction77 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Result of the currency conversion proposed to the cardholder and its result.
    /// </summary>
    [IsoId("_UJxgRdtYEee9e6xduATmQg")]
    [DisplayName("Currency Conversion Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvsRslt")]
    #endif
    [IsoXmlTag("CcyConvsRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CurrencyConversion15? CurrencyConversionResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion15? CurrencyConversionResult { get; init; } 
    #else
    public CurrencyConversion15? CurrencyConversionResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCurrencyConversionResponse7.  ISO2002 ID# _--bdAQuiEeqw5uEXxQ9H4g.
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
/// Currency conversion outcome from the service provider.
/// </summary>
[IsoId("_--bdAQuiEeqw5uEXxQ9H4g")]
[DisplayName("Acceptor Currency Conversion Response")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorCurrencyConversionResponse7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorCurrencyConversionResponse7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorCurrencyConversionResponse7( CardPaymentEnvironment74 reqEnvironment,CardPaymentTransaction93 reqTransaction,CurrencyConversion18 reqCurrencyConversionResult )
    {
        Environment = reqEnvironment;
        Transaction = reqTransaction;
        CurrencyConversionResult = reqCurrencyConversionResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    [IsoId("__Jp1kQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Environment")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Envt")]
    #endif
    [IsoXmlTag("Envt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment74 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentEnvironment74 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment74 Environment { get; init; } 
    #else
    public CardPaymentEnvironment74 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("__Jp1kwuiEeqw5uEXxQ9H4g")]
    [DisplayName("Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tx")]
    #endif
    [IsoXmlTag("Tx")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransaction93 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CardPaymentTransaction93 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction93 Transaction { get; init; } 
    #else
    public CardPaymentTransaction93 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the currency conversion.
    /// </summary>
    [IsoId("__Jp1lQuiEeqw5uEXxQ9H4g")]
    [DisplayName("Currency Conversion Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CcyConvsRslt")]
    #endif
    [IsoXmlTag("CcyConvsRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyConversion18 CurrencyConversionResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required CurrencyConversion18 CurrencyConversionResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion18 CurrencyConversionResult { get; init; } 
    #else
    public CurrencyConversion18 CurrencyConversionResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}

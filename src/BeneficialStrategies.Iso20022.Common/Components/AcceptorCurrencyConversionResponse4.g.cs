﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCurrencyConversionResponse4.  ISO2002 ID# _xq_Jgap6EeanIZ10Ka8PnA.
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
[IsoId("_xq_Jgap6EeanIZ10Ka8PnA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Acceptor Currency Conversion Response")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AcceptorCurrencyConversionResponse4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AcceptorCurrencyConversionResponse4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AcceptorCurrencyConversionResponse4( CardPaymentEnvironment65 reqEnvironment,CardPaymentTransaction77 reqTransaction,CurrencyConversion11 reqCurrencyConversionResult )
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
    [IsoId("_x13j0ap6EeanIZ10Ka8PnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Environment")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentEnvironment65 Environment { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CardPaymentEnvironment65 Environment { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentEnvironment65 Environment { get; init; } 
    #else
    public CardPaymentEnvironment65 Environment { get; set; } 
    #endif
    
    /// <summary>
    /// Currency conversion of a card payment transaction between an acceptor and an acquirer.
    /// </summary>
    [IsoId("_x13j06p6EeanIZ10Ka8PnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CardPaymentTransaction77 Transaction { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CardPaymentTransaction77 Transaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction77 Transaction { get; init; } 
    #else
    public CardPaymentTransaction77 Transaction { get; set; } 
    #endif
    
    /// <summary>
    /// Details of the currency conversion.
    /// </summary>
    [IsoId("_x13j1ap6EeanIZ10Ka8PnA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Currency Conversion Result")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required CurrencyConversion11 CurrencyConversionResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public CurrencyConversion11 CurrencyConversionResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CurrencyConversion11 CurrencyConversionResult { get; init; } 
    #else
    public CurrencyConversion11 CurrencyConversionResult { get; set; } 
    #endif
    
    
    #nullable disable
    
}

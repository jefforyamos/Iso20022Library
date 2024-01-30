﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCurrencyConversionRequest5.  ISO2002 ID# _2IawAdtYEee9e6xduATmQg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the currency conversion request.
/// </summary>
public partial record AcceptorCurrencyConversionRequest5
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment68 Environment { get; init; } 
    /// <summary>
    /// Card payment transaction for which the currency conversion is requested.
    /// </summary>
    public required CardPaymentTransaction85 Transaction { get; init; } 
    
    #nullable disable
}

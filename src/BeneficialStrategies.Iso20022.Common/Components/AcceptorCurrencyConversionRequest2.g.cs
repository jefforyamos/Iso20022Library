﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCurrencyConversionRequest2.  ISO2002 ID# _uopQUWpCEeS4VPLpYyQgxQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the currency conversion request.
/// </summary>
public partial record AcceptorCurrencyConversionRequest2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment44 Environment { get; init; } 
    /// <summary>
    /// Card payment transaction for which the currency conversion is requested.
    /// </summary>
    public required CardPaymentTransaction49 Transaction { get; init; } 
    
    #nullable disable
}

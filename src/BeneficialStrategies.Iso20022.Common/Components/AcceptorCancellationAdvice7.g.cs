﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCancellationAdvice7.  ISO2002 ID# _gKUagdpnEeearpaEPXv9UA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation transaction between an acceptor and an acquirer.
/// </summary>
public partial record AcceptorCancellationAdvice7
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment68 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public CardPaymentContext26? Context { get; init; } 
    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    public required CardPaymentTransaction83 Transaction { get; init; } 
    
    #nullable disable
}

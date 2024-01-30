﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCancellationAdvice4.  ISO2002 ID# _f3zkMWl8EeSxgrJ0GX4SQQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation transaction between an acceptor and an acquirer.
/// </summary>
public partial record AcceptorCancellationAdvice4
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment36 Environment { get; init; } 
    /// <summary>
    /// Context in which the transaction is performed (payment and sale).
    /// </summary>
    public CardPaymentContext11? Context { get; init; } 
    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    public required CardPaymentTransaction44 Transaction { get; init; } 
    
    #nullable disable
}

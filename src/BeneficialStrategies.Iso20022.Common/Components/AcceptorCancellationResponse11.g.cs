﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCancellationResponse11.  ISO2002 ID# _X5bM8XJyEe299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation response from the acquirer.
/// </summary>
public partial record AcceptorCancellationResponse11
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment79 Environment { get; init; } 
    /// <summary>
    /// Cancellation transaction between an acceptor and an acquirer.
    /// </summary>
    public required CardPaymentTransaction117 Transaction { get; init; } 
    /// <summary>
    /// Response from the acquirer to the cancellation transaction.
    /// </summary>
    public required CardPaymentTransaction130 TransactionResponse { get; init; } 
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCancellationAdviceResponse8.  ISO2002 ID# _oy0QEQuaEeqYM5yH99IYQw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation advice response from the acquirer.
/// </summary>
public partial record AcceptorCancellationAdviceResponse8
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment74 Environment { get; init; } 
    /// <summary>
    /// Cancellation transaction from an acceptor to the acquirer.
    /// </summary>
    public required CardPaymentTransactionAdviceResponse7 Transaction { get; init; } 
    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    public TMSTrigger1? TMSTrigger { get; init; } 
    
    #nullable disable
}

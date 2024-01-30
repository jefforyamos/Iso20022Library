﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorCancellationAdviceResponse6.  ISO2002 ID# _aTWxMap5EeanIZ10Ka8PnA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cancellation advice response from the acquirer.
/// </summary>
public partial record AcceptorCancellationAdviceResponse6
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment65 Environment { get; init; } 
    /// <summary>
    /// Cancellation transaction from an acceptor to the acquirer.
    /// </summary>
    public required CardPaymentTransactionAdviceResponse6 Transaction { get; init; } 
    /// <summary>
    /// Instructions for contacting the terminal management host.
    /// </summary>
    public TMSTrigger1? TMSTrigger { get; init; } 
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorReconciliationResponse8.  ISO2002 ID# _2W61YU7TEeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation response from the acquirer.
/// </summary>
public partial record AcceptorReconciliationResponse8
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment78 Environment { get; init; } 
    /// <summary>
    /// Response from the acquirer to the reconciliation transaction.
    /// </summary>
    public required ResponseType10 TransactionResponse { get; init; } 
    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    public required TransactionReconciliation5 Transaction { get; init; } 
    
    #nullable disable
}

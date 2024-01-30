﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorReconciliationResponse9.  ISO2002 ID# _eZXkgXJ1Ee299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation response from the acquirer.
/// </summary>
public partial record AcceptorReconciliationResponse9
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment79 Environment { get; init; } 
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

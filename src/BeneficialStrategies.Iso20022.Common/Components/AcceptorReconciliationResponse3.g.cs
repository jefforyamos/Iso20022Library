﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcceptorReconciliationResponse3.  ISO2002 ID# _BdxRYWmBEeSxgrJ0GX4SQQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reconciliation response from the acquirer.
/// </summary>
public partial record AcceptorReconciliationResponse3
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardPaymentEnvironment38 Environment { get; init; } 
    /// <summary>
    /// Response from the acquirer to the reconciliation transaction.
    /// </summary>
    public required ResponseType1 TransactionResponse { get; init; } 
    /// <summary>
    /// Reconciliation transaction between an acceptor an acquirer.
    /// </summary>
    public required TransactionReconciliation3 Transaction { get; init; } 
    
    #nullable disable
}

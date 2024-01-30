﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerReconciliationResponse1.  ISO2002 ID# _R8Nl0HvBEeSLmfFG0DG7zQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the response to a reconciliation.
/// </summary>
public partial record AcquirerReconciliationResponse1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required CardTransactionEnvironment5 Environment { get; init; } 
    /// <summary>
    /// Reconciliation transaction.
    /// </summary>
    public required CardTransaction10 Transaction { get; init; } 
    
    #nullable disable
}

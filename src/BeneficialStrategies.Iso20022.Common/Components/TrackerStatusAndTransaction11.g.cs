﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TrackerStatusAndTransaction11.  ISO2002 ID# _utoSAVc8EeunQrLahSRvvA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction and it's status to be updated in the tracker.
/// </summary>
public partial record TrackerStatusAndTransaction11
{
    #nullable enable
    
    /// <summary>
    /// Provides detailed information on the transaction status to be updated in the tracker.
    /// </summary>
    public required TrackerStatus4 TransactionStatus { get; init; } 
    /// <summary>
    /// Key elements used to identify the original transaction(s) that is being referred to.
    /// </summary>
    public TrackerPaymentTransaction10[] Transaction { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

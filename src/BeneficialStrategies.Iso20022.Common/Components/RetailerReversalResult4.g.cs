﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RetailerReversalResult4.  ISO2002 ID# _hUjmAU37Eey_VecAUE-C9Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Reversal transaction results after a Reversal request.
/// </summary>
public partial record RetailerReversalResult4
{
    #nullable enable
    
    /// <summary>
    /// POI reconciliation identification.
    /// </summary>
    public IsoMax35Text? POIReconciliationIdentification { get; init; } 
    /// <summary>
    /// Original Transaction if any linked to this reversal.
    /// </summary>
    public CardPaymentTransaction120? OriginalPaymentTransaction { get; init; } 
    /// <summary>
    /// Updated Customer order list after reversal.
    /// </summary>
    public CustomerOrder1[] CustomerOrder { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

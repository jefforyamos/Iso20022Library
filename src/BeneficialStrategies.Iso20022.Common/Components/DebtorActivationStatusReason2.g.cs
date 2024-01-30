﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DebtorActivationStatusReason2.  ISO2002 ID# _P4LStOIKEeqbls7Gk4-ckA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the status reason of the debtor activation request.
/// </summary>
public partial record DebtorActivationStatusReason2
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    public RTPPartyIdentification1? Originator { get; init; } 
    /// <summary>
    /// Specifies the status reason for the debtor activation request.
    /// </summary>
    public required IDebtorActivationStatusReason1Choice Reason { get; init; } 
    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    public IsoMax105Text? AdditionalInformation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

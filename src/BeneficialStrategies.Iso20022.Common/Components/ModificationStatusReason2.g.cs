﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ModificationStatusReason2.  ISO2002 ID# _V2V_M249EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the status of the cancellation request.
/// </summary>
public partial record ModificationStatusReason2
{
    #nullable enable
    
    /// <summary>
    /// Party that issues the cancellation status.
    /// </summary>
    public PartyIdentification135? Originator { get; init; } 
    /// <summary>
    /// Specifies the reason for the status report.
    /// </summary>
    public ModificationStatusReason1Choice_? Reason { get; init; } 
    /// <summary>
    /// Further details on the cancellation status reason.
    /// </summary>
    public IsoMax105Text[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

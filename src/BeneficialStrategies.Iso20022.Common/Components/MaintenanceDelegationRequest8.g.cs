﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegationRequest8.  ISO2002 ID# _OZycgU6oEeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of maintenance delegations.
/// </summary>
public partial record MaintenanceDelegationRequest8
{
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    public required GenericIdentification176 TMIdentification { get; init; } 
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    public GenericIdentification176? MasterTMIdentification { get; init; } 
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    public MaintenanceDelegation13? RequestedDelegation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

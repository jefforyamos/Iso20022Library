﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegationRequest2.  ISO2002 ID# _svUwAY4CEeWrZqsymMFdfg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of maintenance delegations.
/// </summary>
public partial record MaintenanceDelegationRequest2
{
    #nullable enable
    
    /// <summary>
    /// Terminal manager identification.
    /// </summary>
    public required GenericIdentification72 TMIdentification { get; init; } 
    /// <summary>
    /// Master terminal manager identification.
    /// </summary>
    public GenericIdentification72? MasterTMIdentification { get; init; } 
    /// <summary>
    /// Information on the delegation of a maintenance action.
    /// </summary>
    public MaintenanceDelegation3? RequestedDelegation { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

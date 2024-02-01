﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegationResponse1.  ISO2002 ID# _5IxrwGqFEeS8RZDTbvnB_A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request of maintenance delegations.
/// </summary>
public partial record MaintenanceDelegationResponse1
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
    public MaintenanceDelegation2[] DelegationResponse { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

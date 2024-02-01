﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegation16.  ISO2002 ID# _4IKdkXIrEe299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the delegation of a maintenance action or maintenance function.
/// </summary>
public partial record MaintenanceDelegation16
{
    #nullable enable
    
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    public DataSetCategory16Code[] MaintenanceService { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Response of the MTM to the delegation of the maintenance service.
    /// </summary>
    public required Response2Code Response { get; init; } 
    /// <summary>
    /// Reason of the response of the MTM.
    /// </summary>
    public IsoMax35Text? ResponseReason { get; init; } 
    /// <summary>
    /// Type of delegation action.
    /// </summary>
    public required TerminalManagementAction3Code DelegationType { get; init; } 
    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    public IsoMax35Text[] POISubset { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identifies the delegation scope assigned by the MTM.
    /// </summary>
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    /// <summary>
    /// Contains the necessary information to secure the management of the Delegation. The format of this element is out of scope of this definition.
    /// </summary>
    public IsoMax5000Binary? DelegationProof { get; init; } 
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    public ContentInformationType34? ProtectedDelegationProof { get; init; } 
    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    public MaintenanceIdentificationAssociation1[] POIIdentificationAssociation { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

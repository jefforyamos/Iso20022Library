﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegation15.  ISO2002 ID# _rCrVYXIoEe299ZbWCkdR_w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information on the delegation of a maintenance action or maintenance function.
/// </summary>
public partial record MaintenanceDelegation15
{
    #nullable enable
    
    /// <summary>
    /// Type of delegation action.
    /// </summary>
    public required TerminalManagementAction3Code DelegationType { get; init; } 
    /// <summary>
    /// Maintenance service to be delegated.
    /// </summary>
    public DataSetCategory16Code[] MaintenanceService { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Flag to indicate that the delegated maintenance must be performed on a subset of the terminal estate.
    /// </summary>
    public IsoTrueFalseIndicator? PartialDelegation { get; init; } 
    /// <summary>
    /// Subset of the terminal estate for the delegated actions, for instance for pilot or key deactivation). The subset may be expressed as a list of POI or terminal estate subset identifier.
    /// </summary>
    public IsoMax35Text[] POISubset { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Information for the MTM to build or include delegated actions in the management plan of the POI.
    /// </summary>
    public MaintenanceDelegateAction8? DelegatedAction { get; init; } 
    /// <summary>
    /// Identifies the delegation scope assigned by the MTM.
    /// </summary>
    public IsoMax35Text? DelegationScopeIdentification { get; init; } 
    /// <summary>
    /// This element contains all information relevant to the DelegationScopeIdentification. The format of this element is out of scope of this definition.
    /// </summary>
    public IsoMax3000Binary? DelegationScopeDefinition { get; init; } 
    /// <summary>
    /// Certificate path of the terminal manager.
    /// </summary>
    public IsoMax10KBinary[] Certificate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Association of the TM identifier and the MTM identifier of a POI.
    /// </summary>
    public MaintenanceIdentificationAssociation1[] POIIdentificationAssociation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the key to manage or to download.
    /// </summary>
    public KEKIdentifier5[] SymmetricKey { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Configuration parameters of the terminal manager to be sent by the MTM.
    /// </summary>
    public AcceptorConfigurationDataSet4? ParameterDataSet { get; init; } 
    
    #nullable disable
}

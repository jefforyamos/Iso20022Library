﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MaintenanceDelegateAction7.  ISO2002 ID# _tF4y4U6nEeyGi9JAv6wq7Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information for the MTM to build or include delegated actions in the management plan of the POI.
/// </summary>
public partial record MaintenanceDelegateAction7
{
    #nullable enable
    
    /// <summary>
    /// Flag to indicate that the delegated actions have to be included in a periodic sequence of actions.
    /// </summary>
    public IsoTrueFalseIndicator? PeriodicAction { get; init; } 
    /// <summary>
    /// Network address and parameters of the terminal manager host which will performs the delegated actions.
    /// </summary>
    public NetworkParameters7? TMRemoteAccess { get; init; } 
    /// <summary>
    /// TMS protocol to use to perform the maintenance action.
    /// </summary>
    public IsoMax35Text? TMSProtocol { get; init; } 
    /// <summary>
    /// Version of the TMS protocol to use to perform the maintenance action.
    /// </summary>
    public IsoMax35Text? TMSProtocolVersion { get; init; } 
    /// <summary>
    /// Data set on which the delegated action has to be performed.
    /// </summary>
    public DataSetIdentification9? DataSetIdentification { get; init; } 
    /// <summary>
    /// Definition of retry process when activation of the action fails.
    /// </summary>
    public ProcessRetry3? ReTry { get; init; } 
    /// <summary>
    /// Additional information to include in the maintenance action.
    /// </summary>
    public IsoMax3000Binary[] AdditionalInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Sequence of action to include in the next MTM management plan.
    /// </summary>
    public TMSAction10[] Action { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

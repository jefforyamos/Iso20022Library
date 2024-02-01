﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TMSProtocolParameters2.  ISO2002 ID# _XdvNQY34EeWRwov1g9WL_A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters of the TMS protocol between a POI and a terminal manager.
/// </summary>
public partial record TMSProtocolParameters2
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the master terminal manager or the terminal manager.
    /// </summary>
    public required GenericIdentification71 TerminalManagerIdentification { get; init; } 
    /// <summary>
    /// Maintenance services provided by the terminal manager.
    /// </summary>
    public DataSetCategory10Code[] MaintenanceService { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Version of the TMS protocol parameters.
    /// </summary>
    public required IsoMax256Text Version { get; init; } 
    /// <summary>
    /// Identification of applications which may be managed by the TM, partially or globally.
    /// </summary>
    public IsoMax35Text[] ApplicationIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the terminal manager host.
    /// </summary>
    public required IsoMax35Text HostIdentification { get; init; } 
    /// <summary>
    /// New identification of the POI for the terminal manager.
    /// </summary>
    public IsoMax35Text? POIIdentification { get; init; } 
    /// <summary>
    /// New identification of the initiating party to set in TMS messages with this terminal manager.
    /// </summary>
    public IsoMax35Text? InitiatingPartyIdentification { get; init; } 
    /// <summary>
    /// New identification of the recipient party to set in TMS messages with this terminal manager.
    /// </summary>
    public IsoMax35Text? RecipientPartyIdentification { get; init; } 
    /// <summary>
    /// Configuration parameters are exchanged per file transfer protocol rather than per message.
    /// </summary>
    public IsoTrueFalseIndicator? FileTransfer { get; init; } 
    
    #nullable disable
}

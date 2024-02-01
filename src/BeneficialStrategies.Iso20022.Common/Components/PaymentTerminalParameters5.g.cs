﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTerminalParameters5.  ISO2002 ID# _wkqvcdqbEeearpaEPXv9UA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Manufacturer configuration parameters of the point of interaction (POI).
/// </summary>
public partial record PaymentTerminalParameters5
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the vendor for the MTM, if the POI manages various subsets of terminal parameters.
    /// </summary>
    public IsoMax35Text? VendorIdentification { get; init; } 
    /// <summary>
    /// Version of the terminal parameters.
    /// </summary>
    public IsoMax256Text? Version { get; init; } 
    /// <summary>
    /// Parameters to synchronise the real time clock of the POI (Point Of Interaction).
    /// </summary>
    public ClockSynchronisation2? ClockSynchronisation { get; init; } 
    /// <summary>
    /// Time zone line to update in the time zone data base subset stored in the POI (Point Of Interaction). The format of the line is conform to the IANA (Internet Assigned Number Authority) time zone data base.
    /// </summary>
    public IsoMax70Text[] TimeZoneLine { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Local time offset to UTC (Coordinated Universal Time).
    /// </summary>
    public LocalDateTime1[] LocalDateTime { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Others manufacturer configuration parameters of the point of interaction.
    /// </summary>
    public IsoMax10000Binary? OtherParameters { get; init; } 
    
    #nullable disable
}

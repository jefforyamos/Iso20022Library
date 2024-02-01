﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for HostCommunicationParameter5.  ISO2002 ID# _HRfssdqcEeearpaEPXv9UA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters to communicate with a host.
/// </summary>
public partial record HostCommunicationParameter5
{
    #nullable enable
    
    /// <summary>
    /// Type of action for the configuration parameters.
    /// </summary>
    public required TerminalManagementAction3Code ActionType { get; init; } 
    /// <summary>
    /// Identification of the host.
    /// </summary>
    public required IsoMax35Text HostIdentification { get; init; } 
    /// <summary>
    /// Network parameters of the host.
    /// </summary>
    public NetworkParameters5? Address { get; init; } 
    /// <summary>
    /// Cryptographic key used to communicate with the host.
    /// </summary>
    public KEKIdentifier5[] Key { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Access information to reach an intermediate network service provider.
    /// </summary>
    public NetworkParameters5? NetworkServiceProvider { get; init; } 
    /// <summary>
    /// Physical Interface where the host is connected.
    /// </summary>
    public PhysicalInterfaceParameter1? PhysicalInterface { get; init; } 
    
    #nullable disable
}

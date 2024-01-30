﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerHostConfiguration7.  ISO2002 ID# _8ybk4Au1Eeq4I6UJxZQ2Qw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer configuration parameters for a host.
/// </summary>
public partial record AcquirerHostConfiguration7
{
    #nullable enable
    
    /// <summary>
    /// Identification of a host.
    /// </summary>
    public required IsoMax35Text HostIdentification { get; init; } 
    /// <summary>
    /// Types of message to sent to this host.
    /// </summary>
    public MessageFunction40Code? MessageToSend { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Protocol version to use when using these parameters.
    /// </summary>
    public IsoMax8Text? ProtocolVersion { get; init; } 
    
    #nullable disable
}

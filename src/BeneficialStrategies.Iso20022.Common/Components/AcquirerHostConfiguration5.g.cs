﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AcquirerHostConfiguration5.  ISO2002 ID# _9OqiYdqGEeearpaEPXv9UA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Acquirer configuration parameters for a host.
/// </summary>
public partial record AcquirerHostConfiguration5
{
    #nullable enable
    
    /// <summary>
    /// Identification of a host.
    /// </summary>
    public required IsoMax35Text HostIdentification { get; init; } 
    /// <summary>
    /// Types of message to sent to this host.
    /// </summary>
    public MessageFunction15Code[] MessageToSend { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

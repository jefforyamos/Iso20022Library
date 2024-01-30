﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for HostToATMRequest1.  ISO2002 ID# _nkIKwItqEeSDLd7nI4Quzw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the request to an ATM to contact the ATM manager.
/// </summary>
public partial record HostToATMRequest1
{
    #nullable enable
    
    /// <summary>
    /// Environment of the ATM.
    /// </summary>
    public required ATMEnvironment9 Environment { get; init; } 
    /// <summary>
    /// Identification of the entity issuing the command.
    /// </summary>
    public ATMCommandIdentification1? CommandIdentification { get; init; } 
    /// <summary>
    /// Message that have to be sent by the ATM.
    /// </summary>
    public required MessageFunction8Code ExpectedMessageFunction { get; init; } 
    
    #nullable disable
}

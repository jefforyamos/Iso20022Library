﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceTransmitMessageResponse1.  ISO2002 ID# _EFdOMN7JEeiwsev40qZGEQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Content of the Transmit Response message.
/// </summary>
public partial record DeviceTransmitMessageResponse1
{
    #nullable enable
    
    /// <summary>
    /// Content of a transmitted message.
    /// </summary>
    public IsoMax100KBinary? ReceivedMessage { get; init; } 
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMDeviceControl2.  ISO2002 ID# _GmxrcV27EeekzJIz1JxYSQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information related to the control of an ATM device.
/// </summary>
public partial record ATMDeviceControl2
{
    #nullable enable
    
    /// <summary>
    /// Environment of the transaction.
    /// </summary>
    public required ATMEnvironment7 Environment { get; init; } 
    /// <summary>
    /// Maintenance command the ATM must perform.
    /// </summary>
    public ATMCommand10[] Command { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

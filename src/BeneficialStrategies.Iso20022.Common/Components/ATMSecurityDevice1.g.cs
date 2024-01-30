﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMSecurityDevice1.  ISO2002 ID# _6LYrIIr5EeSvuOJS0mmL0g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Hardware security module of the ATM.
/// </summary>
public partial record ATMSecurityDevice1
{
    #nullable enable
    
    /// <summary>
    /// Hardware security module information, so called EPP for Encrypted PIN Pad.
    /// </summary>
    public ATMEquipment2? DeviceProperty { get; init; } 
    /// <summary>
    /// Configuration parameters in use by the security device.
    /// </summary>
    public required ATMSecurityConfiguration1 CurrentConfiguration { get; init; } 
    /// <summary>
    /// Configuration parameters supported by the security device.
    /// </summary>
    public ATMSecurityConfiguration1? SupportedConfiguration { get; init; } 
    /// <summary>
    /// Current status of the security device.
    /// </summary>
    public required ATMStatus2Code CurrentStatus { get; init; } 
    /// <summary>
    /// Incident occurring on the device.
    /// </summary>
    public FailureReason5Code? Incident { get; init; } 
    
    #nullable disable
}

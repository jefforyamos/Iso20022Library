﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DeviceSecureInputRequest4.  ISO2002 ID# _U4EtwVFJEeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Request a secure input for a PIN.
/// </summary>
public partial record DeviceSecureInputRequest4
{
    #nullable enable
    
    /// <summary>
    /// Type of PIN Service.
    /// </summary>
    public required PINRequestType1Code PINRequestType { get; init; } 
    /// <summary>
    /// Identify the PIN verification method and keys.
    /// </summary>
    public IsoMax35Text? PINVerificationMethod { get; init; } 
    /// <summary>
    /// Maximum time to wait for the request processing in seconds.
    /// </summary>
    public IsoNumber? MaximumWaitingTime { get; init; } 
    /// <summary>
    /// Indicates, when the user press a key, if a beep has to be generated.
    /// </summary>
    public IsoTrueFalseIndicator? BeepKeyFlag { get; init; } 
    /// <summary>
    /// Enciphered PIN and related information.
    /// </summary>
    public OnLinePIN9? CardholderPIN { get; init; } 
    
    #nullable disable
}

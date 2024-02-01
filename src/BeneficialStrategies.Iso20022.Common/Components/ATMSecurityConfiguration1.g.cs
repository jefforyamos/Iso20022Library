﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMSecurityConfiguration1.  ISO2002 ID# _4FKwEIr6EeSvuOJS0mmL0g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Configuration parameters in use by the security device.
/// </summary>
public partial record ATMSecurityConfiguration1
{
    #nullable enable
    
    /// <summary>
    /// Configuration of the cryptographic keys.
    /// </summary>
    public ATMSecurityConfiguration2? Keys { get; init; } 
    /// <summary>
    /// Configuration of the encryption or digital envelope, if the security module is able to perform encryption.
    /// </summary>
    public ATMSecurityConfiguration3? Encryption { get; init; } 
    /// <summary>
    /// MAC (Message Authentication Code) algorithm the security module is able to manage.
    /// </summary>
    public Algorithm12Code[] MACAlgorithm { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Digest algorithm the security module is able to manage.
    /// </summary>
    public Algorithm11Code[] DigestAlgorithm { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Configuration of the digital signatures if the security module is able to perform digital signatures with an asymmetric key.
    /// </summary>
    public ATMSecurityConfiguration4? DigitalSignature { get; init; } 
    /// <summary>
    /// Configuration of the PIN online verification.
    /// </summary>
    public ATMSecurityConfiguration5? PIN { get; init; } 
    /// <summary>
    /// Mechanism used to protect the message of the ATM protocol.
    /// </summary>
    public MessageProtection1Code[] MessageProtection { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

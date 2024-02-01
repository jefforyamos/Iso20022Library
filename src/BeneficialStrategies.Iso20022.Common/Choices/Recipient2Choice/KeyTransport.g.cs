﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KeyTransport.  ISO2002 ID# _E8e4BQioEeKn9O5oyej_zw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient2Choice;

/// <summary>
/// Encryption key using previously distributed asymmetric public key.
/// </summary>
public partial record KeyTransport : Recipient2Choice_
{
    #nullable enable
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    public required IsoNumber Version { get; init; } 
    /// <summary>
    /// Transport key or key encryption key (KEK) for the recipient.
    /// </summary>
    public required CertificateIdentifier1 RecipientIdentification { get; init; } 
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    public required AlgorithmIdentification7 KeyEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    public required IsoMax140Binary EncryptedKey { get; init; } 
    #nullable disable
}

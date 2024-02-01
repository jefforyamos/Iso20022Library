﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KeyTransport.  ISO2002 ID# _Wyk0gS8jEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient10Choice;

/// <summary>
/// Encryption key using previously distributed asymmetric public key.
/// </summary>
public partial record KeyTransport : Recipient10Choice_
{
    #nullable enable
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of a cryptographic asymmetric key for the recipient.
    /// </summary>
    public required Recipient9Choice_ RecipientIdentification { get; init; } 
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    public required AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    public required IsoMax5000Binary EncryptedKey { get; init; } 
    #nullable disable
}

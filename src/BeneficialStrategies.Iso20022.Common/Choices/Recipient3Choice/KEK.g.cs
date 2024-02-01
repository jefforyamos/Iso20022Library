﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KEK.  ISO2002 ID# _lPQMIy9eEeOlZIh7PImd0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient3Choice;

/// <summary>
/// Encryption key using previously distributed symmetric key.
/// </summary>
public partial record KEK : Recipient3Choice_
{
    #nullable enable
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of the key encryption key (KEK).
    /// </summary>
    public required KEKIdentifier1 KEKIdentification { get; init; } 
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    public required AlgorithmIdentification9 KeyEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    public required IsoMax140Binary EncryptedKey { get; init; } 
    #nullable disable
}

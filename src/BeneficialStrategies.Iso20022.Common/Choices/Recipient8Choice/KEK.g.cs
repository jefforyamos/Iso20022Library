﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KEK.  ISO2002 ID# _EE9KgwxqEeqdx6buGpCCQw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Recipient8Choice;

/// <summary>
/// Key encryption key using previously distributed symmetric key.
/// </summary>
public partial record KEK : IRecipient8Choice
{
    #nullable enable
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of the key encryption key (KEK).
    /// </summary>
    public required KEKIdentifier2 KEKIdentification { get; init; } 
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    public required AlgorithmIdentification29 KeyEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    public required IsoMax500Binary EncryptedKey { get; init; } 
    #nullable disable
}

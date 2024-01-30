﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for KEK.  ISO2002 ID# _Wyk0gy8jEeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Recipient10Choice;

/// <summary>
/// Key encryption key using previously distributed symmetric key.
/// </summary>
public partial record KEK : IRecipient10Choice
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

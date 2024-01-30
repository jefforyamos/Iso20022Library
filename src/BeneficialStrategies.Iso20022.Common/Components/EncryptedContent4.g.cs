﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EncryptedContent4.  ISO2002 ID# _jiCQcdtoEee9e6xduATmQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with an encryption key.
/// </summary>
public partial record EncryptedContent4
{
    #nullable enable
    
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    public required ContentType2Code ContentType { get; init; } 
    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    public AlgorithmIdentification24? ContentEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    public required IsoMax100KBinary EncryptedData { get; init; } 
    
    #nullable disable
}

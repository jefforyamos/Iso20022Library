﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EncryptedContent3.  ISO2002 ID# _tsmQMWjAEeSP8Z8nx8HTuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with an encryption key.
/// </summary>
public partial record EncryptedContent3
{
    #nullable enable
    
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    public required ContentType2Code ContentType { get; init; } 
    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    public required AlgorithmIdentification14 ContentEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    public required IsoMax100KBinary EncryptedData { get; init; } 
    
    #nullable disable
}

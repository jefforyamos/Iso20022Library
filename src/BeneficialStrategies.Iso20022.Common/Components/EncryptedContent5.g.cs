﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EncryptedContent5.  ISO2002 ID# _v-VR0aQtEeeWXKXf3KjtmQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Encrypted data with an encryption key.
/// </summary>
[DataContract]
[XmlType]
public partial record EncryptedContent5
{
    #nullable enable
    
    /// <summary>
    /// Type of data which have been encrypted.
    /// </summary>
    [DataMember]
    public required ContentType2Code ContentType { get; init; } 
    /// <summary>
    /// Algorithm used to encrypt the data.
    /// </summary>
    [DataMember]
    public required AlgorithmIdentification25 ContentEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted data, result of the content encryption.
    /// </summary>
    [DataMember]
    public ValueList<EncryptedDataElement1> EncryptedDataElement { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

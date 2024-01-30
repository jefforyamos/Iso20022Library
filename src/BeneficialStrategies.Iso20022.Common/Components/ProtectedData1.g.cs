﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ProtectedData1.  ISO2002 ID# _SmzOEEYdEeegp_DADCe7HQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains protected data and the attributes used to protect the data.
/// </summary>
public partial record ProtectedData1
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    public required ContentType3Code ContentType { get; init; } 
    /// <summary>
    /// Consists of an encrypted content of any type and encrypted content-encryption keys for one or more recipients.  The combination of the encrypted content and one encrypted content-encryption key for a recipient is a "digital   envelope" for that recipient.
    /// </summary>
    public EnvelopedData6? EnvelopedData { get; init; } 
    /// <summary>
    /// Contains encrypted data and the attributes used to encrypt the data using the ISO 13492 methods for data encryption.  The encryption key is not included in the message with this method.
    /// </summary>
    public EncryptedData1? EncryptedData { get; init; } 
    
    #nullable disable
}

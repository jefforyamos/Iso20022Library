﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for KeyTransport9.  ISO2002 ID# _9jkI4XDDEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key encryption key (KEK), encrypted with a previously distributed asymmetric public key.
/// </summary>
[DataContract]
[XmlType]
public partial record KeyTransport9
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [DataMember]
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of a cryptographic asymmetric key for the recipient.
    /// </summary>
    [DataMember]
    public required Recipient13Choice_ RecipientIdentification { get; init; } 
    /// <summary>
    /// Algorithm to encrypt the key encryption key (KEK).
    /// </summary>
    [DataMember]
    public required AlgorithmIdentification19 KeyEncryptionAlgorithm { get; init; } 
    /// <summary>
    /// Encrypted key encryption key (KEK).
    /// </summary>
    [DataMember]
    public required IsoMax5000Binary EncryptedKey { get; init; } 
    
    #nullable disable
}

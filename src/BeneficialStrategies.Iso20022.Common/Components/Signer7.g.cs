﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Signer7.  ISO2002 ID# _q1KeIXDFEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity who has signed the data and its digital signature.
/// </summary>
[DataContract]
[XmlType]
public partial record Signer7
{
    #nullable enable
    
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    [DataMember]
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of the entity who has signed the data.
    /// </summary>
    [DataMember]
    public Recipient13Choice_? SignerIdentification { get; init; } 
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [DataMember]
    public required AlgorithmIdentification21 DigestAlgorithm { get; init; } 
    /// <summary>
    /// Collection of attributes that are signed.
    /// </summary>
    [DataMember]
    public ValueList<GenericInformation1> SignedAttributes { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    [DataMember]
    public required AlgorithmIdentification30 SignatureAlgorithm { get; init; } 
    /// <summary>
    /// Digital signature.
    /// </summary>
    [DataMember]
    public required IsoMax3000Binary Signature { get; init; } 
    
    #nullable disable
}

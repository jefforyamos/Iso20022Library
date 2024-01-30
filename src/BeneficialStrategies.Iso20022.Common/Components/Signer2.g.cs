﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Signer2.  ISO2002 ID# _6sFCYQirEeKn9O5oyej_zw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity who has signed the data and its digital signature.
/// </summary>
public partial record Signer2
{
    #nullable enable
    
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of the entity who has signed the data.
    /// </summary>
    public required CertificateIdentifier1 SignerIdentification { get; init; } 
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    public required AlgorithmIdentification5 DigestAlgorithm { get; init; } 
    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    public required AlgorithmIdentification4 SignatureAlgorithm { get; init; } 
    /// <summary>
    /// Digital signature.
    /// </summary>
    public required IsoMax500Binary Signature { get; init; } 
    
    #nullable disable
}

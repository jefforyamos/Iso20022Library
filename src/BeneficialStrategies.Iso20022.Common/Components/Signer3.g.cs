﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Signer3.  ISO2002 ID# _krtoAWmQEeS7iYydEtv3Ug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity who has signed the data and its digital signature.
/// </summary>
public partial record Signer3
{
    #nullable enable
    
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of the entity who has signed the data.
    /// </summary>
    public IRecipient5Choice? SignerIdentification { get; init; } 
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    public required AlgorithmIdentification16 DigestAlgorithm { get; init; } 
    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    public required AlgorithmIdentification17 SignatureAlgorithm { get; init; } 
    /// <summary>
    /// Digital signature.
    /// </summary>
    public required IsoMax3000Binary Signature { get; init; } 
    
    #nullable disable
}

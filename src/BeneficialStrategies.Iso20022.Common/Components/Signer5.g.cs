﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Signer5.  ISO2002 ID# _SUqPAS80Eeu125Ip9zFcsQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity who has signed the data and its digital signature.
/// </summary>
public partial record Signer5
{
    #nullable enable
    
    /// <summary>
    /// Version of the Cryptographic Message Syntax (CMS) data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of the entity who has signed the data.
    /// </summary>
    public IRecipient9Choice? SignerIdentification { get; init; } 
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    public required AlgorithmIdentification21 DigestAlgorithm { get; init; } 
    /// <summary>
    /// Collection of attributes that are signed.
    /// </summary>
    public GenericInformation1? SignedAttributes { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Cryptographic digital signature algorithm.
    /// </summary>
    public required AlgorithmIdentification30 SignatureAlgorithm { get; init; } 
    /// <summary>
    /// Digital signature.
    /// </summary>
    public required IsoMax3000Binary Signature { get; init; } 
    
    #nullable disable
}

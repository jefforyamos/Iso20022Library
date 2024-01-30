﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SignedData2.  ISO2002 ID# _HkKvIQisEeKn9O5oyej_zw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital signature of data, with an asymmetric key.
/// </summary>
public partial record SignedData2
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    public AlgorithmIdentification5? DigestAlgorithm { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Data to sign.
    /// </summary>
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    public IsoMax3000Binary? Certificate { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity who has signed the data.
    /// </summary>
    public Signer2? Signer { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

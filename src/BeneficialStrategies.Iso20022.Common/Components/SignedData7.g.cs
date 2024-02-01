﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SignedData7.  ISO2002 ID# _4_PTwVFKEeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital signatures of data from one or several signers.
/// </summary>
public partial record SignedData7
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of digest algorithm applied before signature.
    /// </summary>
    public AlgorithmIdentification21[] DigestAlgorithm { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data to sign.
    /// </summary>
    public EncapsulatedContent3? EncapsulatedContent { get; init; } 
    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    public IsoMax5000Binary[] Certificate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Digital signature and identification of a signer.
    /// </summary>
    public Signer6[] Signer { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

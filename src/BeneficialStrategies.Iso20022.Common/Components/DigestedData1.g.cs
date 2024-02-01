﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DigestedData1.  ISO2002 ID# _SwiSzgEcEeCQm6a_G2yO_w_-1031438550.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digest computed on the identified data.
/// </summary>
public partial record DigestedData1
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of a digest algorithm.
    /// </summary>
    public AlgorithmIdentification1[] DigestAlgorithm { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data on which the digest is computed.
    /// </summary>
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    /// <summary>
    /// Result of data-digesting process.
    /// </summary>
    public required IsoMax140Text Digest { get; init; } 
    
    #nullable disable
}

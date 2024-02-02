﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SignedData1.  ISO2002 ID# _SwiSxQEcEeCQm6a_G2yO_w_423305328.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Digital signature of data, with an asymmetric key.
/// </summary>
[DataContract]
[XmlType]
public partial record SignedData1
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    [DataMember]
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Identification of a digest algorithm to apply before signature.
    /// </summary>
    [DataMember]
    public ValueList<AlgorithmIdentification1> DigestAlgorithm { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Data to sign.
    /// </summary>
    [DataMember]
    public required EncapsulatedContent1 EncapsulatedContent { get; init; } 
    /// <summary>
    /// Chain of X.509 certificates.
    /// </summary>
    [DataMember]
    public ValueList<IsoMax3000Binary> Certificate { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Entity who has signed the data.
    /// </summary>
    [DataMember]
    public ValueList<Signer1> Signer { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

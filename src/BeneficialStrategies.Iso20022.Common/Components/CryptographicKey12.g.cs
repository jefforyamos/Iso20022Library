﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CryptographicKey12.  ISO2002 ID# _47wD8bTwEeeQy4o2AayYHg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic key.
/// </summary>
[DataContract]
[XmlType]
public partial record CryptographicKey12
{
    #nullable enable
    
    /// <summary>
    /// Name or label of the key.
    /// </summary>
    [DataMember]
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Name of the cryptographic key.
    /// </summary>
    [DataMember]
    public IsoMax140Text? Identification { get; init; } 
    /// <summary>
    /// Identification of the security domain.
    /// </summary>
    [DataMember]
    public IsoMax35Text? SecurityDomainIdentification { get; init; } 
    /// <summary>
    /// Additional identification of the key, for instance to derive the key.
    /// </summary>
    [DataMember]
    public IsoMax35Binary? AdditionalIdentification { get; init; } 
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    [DataMember]
    public IsoMax256Text? Version { get; init; } 
    /// <summary>
    /// Sequence counter of the cryptographic key.
    /// </summary>
    [DataMember]
    public IsoNumber? SequenceCounter { get; init; } 
    /// <summary>
    /// Type of algorithm used by the cryptographic key.
    /// </summary>
    [DataMember]
    public CryptographicKeyType3Code? Type { get; init; } 
    /// <summary>
    /// Allowed usage of the key.
    /// </summary>
    [DataMember]
    public ValueList<KeyUsage1Code> Function { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Date and time on which the key must be activated.
    /// </summary>
    [DataMember]
    public IsoISODateTime? ActivationDate { get; init; } 
    /// <summary>
    /// Date and time on which the key must be deactivated.
    /// </summary>
    [DataMember]
    public IsoISODateTime? DeactivationDate { get; init; } 
    /// <summary>
    /// Value for checking a cryptographic key.
    /// </summary>
    [DataMember]
    public IsoMax35Binary? KeyCheckValue { get; init; } 
    /// <summary>
    /// Value of the public component of a RSA key.
    /// </summary>
    [DataMember]
    public PublicRSAKey1? PublicKeyValue { get; init; } 
    /// <summary>
    /// Element containing the key information.
    /// </summary>
    [DataMember]
    public KeyChoiceValue2_? KeyChoiceValue { get; init; } 
    
    #nullable disable
}

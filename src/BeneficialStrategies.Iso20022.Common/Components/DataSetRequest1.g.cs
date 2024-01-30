﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DataSetRequest1.  ISO2002 ID# _QLwe0A0bEeqUVL7sB4m7NA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of requested data set.
/// </summary>
public partial record DataSetRequest1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    public required DataSetIdentification8 Identification { get; init; } 
    /// <summary>
    /// Point of interaction challenge for cryptographic key injection.
    /// </summary>
    public IsoMax140Binary? POIChallenge { get; init; } 
    /// <summary>
    /// Terminal manager challenge for cryptographic key injection.
    /// </summary>
    public IsoMax140Binary? TMChallenge { get; init; } 
    /// <summary>
    /// Temporary encryption key that the host will use for protecting keys to download.
    /// </summary>
    public CryptographicKey14? SessionKey { get; init; } 
    /// <summary>
    /// Proof of delegation to be validated by the terminal manager receiving a status report from a new POI.
    /// </summary>
    public IsoMax5000Binary? DelegationProof { get; init; } 
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    public ContentInformationType23? ProtectedDelegationProof { get; init; } 
    
    #nullable disable
}

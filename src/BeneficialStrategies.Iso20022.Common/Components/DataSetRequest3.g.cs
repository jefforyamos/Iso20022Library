﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DataSetRequest3.  ISO2002 ID# _LBawUVEKEeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of requested data set.
/// </summary>
public partial record DataSetRequest3
{
    #nullable enable
    
    /// <summary>
    /// Identification of the required data set.
    /// </summary>
    public required DataSetIdentification9 Identification { get; init; } 
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
    public CryptographicKey16? SessionKey { get; init; } 
    /// <summary>
    /// Proof of delegation to be validated by the terminal manager receiving a status report from a new POI.
    /// </summary>
    public IsoMax5000Binary? DelegationProof { get; init; } 
    /// <summary>
    /// Protected proof of delegation.
    /// </summary>
    public ContentInformationType30? ProtectedDelegationProof { get; init; } 
    
    #nullable disable
}

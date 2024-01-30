﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContentInformationType34.  ISO2002 ID# _smMyYXDPEe2MCaKO5AtGsA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing protected data.
/// </summary>
public partial record ContentInformationType34
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    public required ContentType2Code ContentType { get; init; } 
    /// <summary>
    /// Data protection by encryption, with a session key.
    /// </summary>
    public EnvelopedData10? EnvelopedData { get; init; } 
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    public AuthenticatedData9? AuthenticatedData { get; init; } 
    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    public SignedData8? SignedData { get; init; } 
    /// <summary>
    /// Data protected by a digest.
    /// </summary>
    public DigestedData5? DigestedData { get; init; } 
    
    #nullable disable
}

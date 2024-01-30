﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ContentInformationType29.  ISO2002 ID# _uXF14VE1EeyApZmLzm74zA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// General cryptographic message syntax (CMS) containing data. protected by a MAC or a digital signature.
/// </summary>
public partial record ContentInformationType29
{
    #nullable enable
    
    /// <summary>
    /// Type of data protection.
    /// </summary>
    public required ContentType2Code ContentType { get; init; } 
    /// <summary>
    /// Data protection by a message authentication code (MAC).
    /// </summary>
    public AuthenticatedData8? AuthenticatedData { get; init; } 
    /// <summary>
    /// Data protected by a digital signatures.
    /// </summary>
    public SignedData7? SignedData { get; init; } 
    
    #nullable disable
}

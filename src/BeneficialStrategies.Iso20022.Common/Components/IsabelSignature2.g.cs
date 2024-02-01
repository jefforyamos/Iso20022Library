﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IsabelSignature2.  ISO2002 ID# _Z-CoUKA3EeWiJt5KdX5iuQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the signature of an Isabel file.
/// </summary>
public partial record IsabelSignature2
{
    #nullable enable
    
    /// <summary>
    /// Common signature elements applicable to all signature records.
    /// </summary>
    public required IsabelSignatureHash1 Header { get; init; } 
    /// <summary>
    /// Individual record of the file signature.
    /// </summary>
    public IsabelSignatureRecord1[] Record { get; init; } = [];
    /// <summary>
    /// Random data related to the signature.
    /// </summary>
    public required IsoMax64Text RandomBlock { get; init; } 
    
    #nullable disable
}

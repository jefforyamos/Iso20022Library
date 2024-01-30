﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmIdentification24.  ISO2002 ID# _Zw01EdtoEee9e6xduATmQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithm and parameters for encryptions with a symmetric cryptographic key.
/// </summary>
public partial record AlgorithmIdentification24
{
    #nullable enable
    
    /// <summary>
    /// Identification of the encryption algorithm.
    /// </summary>
    public required Algorithm18Code Algorithm { get; init; } 
    /// <summary>
    /// Parameters associated with the CBC (Chain Block Chaining) encryption algorithm.
    /// </summary>
    public Parameter12? Parameter { get; init; } 
    
    #nullable disable
}

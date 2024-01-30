﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmIdentification29.  ISO2002 ID# _CZaA8QxlEeqEbo60f0v6aw.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithm and parameters for the protection of the transported key.
/// </summary>
public partial record AlgorithmIdentification29
{
    #nullable enable
    
    /// <summary>
    /// Identification of the algorithm.
    /// </summary>
    public required Algorithm24Code Algorithm { get; init; } 
    /// <summary>
    /// Parameters associated to the encryption algorithm.
    /// </summary>
    public Parameter12? Parameter { get; init; } 
    
    #nullable disable
}

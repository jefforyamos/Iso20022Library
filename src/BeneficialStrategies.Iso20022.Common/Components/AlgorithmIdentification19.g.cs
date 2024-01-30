﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AlgorithmIdentification19.  ISO2002 ID# _m4fhods2Eee9e6xduATmQg.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Cryptographic algorithms and parameters for the protection of transported keys by an asymmetric key.
/// </summary>
public partial record AlgorithmIdentification19
{
    #nullable enable
    
    /// <summary>
    /// Asymmetric encryption algorithm of a transport key.
    /// </summary>
    public required Algorithm7Code Algorithm { get; init; } 
    /// <summary>
    /// Parameters of the encryption algorithm.
    /// </summary>
    public Parameter10? Parameter { get; init; } 
    
    #nullable disable
}

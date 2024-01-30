﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for KEKIdentifier3.  ISO2002 ID# _MXlzwXvOEeSCJdwgzb6SFw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Key that must be created and sent in the response, or that must be verified.
/// </summary>
public partial record KEKIdentifier3
{
    #nullable enable
    
    /// <summary>
    /// Name or label of the key.
    /// </summary>
    public IsoMax140Text? Name { get; init; } 
    /// <summary>
    /// Identification of the cryptographic key.
    /// </summary>
    public required IsoMax140Text Identification { get; init; } 
    /// <summary>
    /// Version of the cryptographic key.
    /// </summary>
    public IsoMax140Text? Version { get; init; } 
    /// <summary>
    /// Value to check the key, for instance, result of the encryption of the null binary string.
    /// </summary>
    public IsoMax35Binary? KeyCheckValue { get; init; } 
    
    #nullable disable
}

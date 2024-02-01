﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AuthenticatedData5.  ISO2002 ID# _NkVgUds3Eee9e6xduATmQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Message authentication code (MAC), computed on the data to protect with an encryption key.
/// </summary>
public partial record AuthenticatedData5
{
    #nullable enable
    
    /// <summary>
    /// Version of the data structure.
    /// </summary>
    public IsoNumber? Version { get; init; } 
    /// <summary>
    /// Session key or protection key identification used by the recipient.
    /// </summary>
    public Recipient6Choice_[] Recipient { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Algorithm to compute message authentication code (MAC).
    /// </summary>
    public required AlgorithmIdentification22 MACAlgorithm { get; init; } 
    /// <summary>
    /// Data to authenticate.
    /// </summary>
    public required EncapsulatedContent3 EncapsulatedContent { get; init; } 
    /// <summary>
    /// Message authentication code value.
    /// </summary>
    public required IsoMax140Binary MAC { get; init; } 
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _SumZGgEcEeCQm6a_G2yO_w_-1320697182.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ChargeTypeFormat3Choice;

/// <summary>
/// Proprietary code for specifying the type of charge.
/// </summary>
public partial record Proprietary : IChargeTypeFormat3Choice
{
    #nullable enable
    /// <summary>
    /// Identification assigned by an institution.
    /// </summary>
    public required IsoMax4AlphaNumericText Identification { get; init; } 
    /// <summary>
    /// Name of the identification scheme.
    /// </summary>
    public IsoMax35Text? SchemeName { get; init; } 
    /// <summary>
    /// Entity that assigns the identification.
    /// </summary>
    public required IsoMax35Text Issuer { get; init; } 
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _Rl9PMtp-Ed-ak6NoX_4Aeg_-346025187.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ConversionType1FormatChoice;

/// <summary>
/// Proprietary code to express the type of conversion.
/// </summary>
public partial record Proprietary : IConversionType1FormatChoice
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

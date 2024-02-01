﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DigitalTokenAmount.  ISO2002 ID# _JFyZAANiEe2-vqzwMUAewg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CurrencyOrDigitalTokenAmount1Choice;

/// <summary>
/// Amount specified as a non-ISO currency (ISO 4217).
/// </summary>
public partial record DigitalTokenAmount : CurrencyOrDigitalTokenAmount1Choice_
{
    #nullable enable
    /// <summary>
    /// Specifies the digital token identifier (DTI).
    /// </summary>
    public IsoDTI2021Identifier? Identifier { get; init; } 
    /// <summary>
    /// Quantity of digital tokens expressed as a number, for example, a number of blockchain tokens.
    /// </summary>
    public required IsoMax30DecimalNumber Unit { get; init; } 
    /// <summary>
    /// Provides a description of the digital token identifier.
    /// </summary>
    public IsoMax30Text? Description { get; init; } 
    #nullable disable
}

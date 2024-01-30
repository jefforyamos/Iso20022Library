﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for EqualQuantity.  ISO2002 ID# _jtRfE-5NEeCisYr99QEiWA_-675705255.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuantityRange1Choice;

/// <summary>
/// Exact value a quantity must match to be considered valid.
/// </summary>
public partial record EqualQuantity : IQuantityRange1Choice
{
    public required IsoDecimalNumber Value { get; init; }
}

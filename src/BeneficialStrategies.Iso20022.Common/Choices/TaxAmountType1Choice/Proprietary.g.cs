﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _ts1L0FkyEeGeoaLUQk__nA_281564711.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TaxAmountType1Choice;

/// <summary>
/// Specifies the amount type, in a free-text form.
/// </summary>
public partial record Proprietary : ITaxAmountType1Choice
{
    public required IsoMax35Text Value { get; init; }
}

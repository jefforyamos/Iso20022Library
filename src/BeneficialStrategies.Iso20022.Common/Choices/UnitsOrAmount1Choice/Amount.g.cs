﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _l0iy4BQcEeKebsB9eKJSkA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnitsOrAmount1Choice;

/// <summary>
/// Currency and amount of the periodical payments.
/// </summary>
public partial record Amount : IUnitsOrAmount1Choice
{
    public required IsoActiveCurrencyAndAmount Value { get; init; }
}

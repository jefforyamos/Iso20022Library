﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Floating.  ISO2002 ID# _VdT5QHg2EeuXJdYjLmnO3w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Rates1Choice;

/// <summary>
/// Details about the variable rate.
/// </summary>
public partial record Floating : IRates1Choice
{
    public required ExternalRatesAndTenors1Code Value { get; init; }
}

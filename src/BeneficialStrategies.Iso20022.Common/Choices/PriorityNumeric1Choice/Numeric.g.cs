﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Numeric.  ISO2002 ID# _QuYG8dp-Ed-ak6NoX_4Aeg_971634575.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PriorityNumeric1Choice;

/// <summary>
/// Specifies the execution priority of the instruction with a number between 0001 and 9999.
/// </summary>
public partial record Numeric : IPriorityNumeric1Choice
{
    public required IsoExact4NumericText Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q7368K-WEemJ1NnLPsTFaw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.QuantityOrCode1Choice;

/// <summary>
/// Quantity expressed as a code.
/// </summary>
public partial record Code : IQuantityOrCode1Choice
{
    public required Quantity1Code Value { get; init; }
}

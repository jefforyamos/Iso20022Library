﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Months.  ISO2002 ID# _95fqcXltEeG7BsjMvd1mEw_-1160957517.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AutoExtend1Choice;

/// <summary>
/// Number of months.
/// </summary>
public partial record Months : IAutoExtend1Choice
{
    public required IsoNumber Value { get; init; }
}

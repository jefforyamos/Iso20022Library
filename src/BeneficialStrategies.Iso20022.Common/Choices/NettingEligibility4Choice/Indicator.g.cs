﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _1CkuITqIEeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.NettingEligibility4Choice;

/// <summary>
/// Specifies whether the settlement transaction is eligible for netting.
/// </summary>
public partial record Indicator : INettingEligibility4Choice
{
    public required IsoYesNoIndicator Value { get; init; }
}

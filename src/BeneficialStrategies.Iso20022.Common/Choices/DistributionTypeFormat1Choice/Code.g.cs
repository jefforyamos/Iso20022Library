﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q3nihtp-Ed-ak6NoX_4Aeg_2019414254.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DistributionTypeFormat1Choice;

/// <summary>
/// Standard code to specify whether the proceeds of the event will be distributed on a rolling basis rather than on a specific date.
/// </summary>
public partial record Code : IDistributionTypeFormat1Choice
{
    public required DistributionType1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _anZPguwOEd-sn-FiNtktcA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat11Choice;

/// <summary>
/// Value of the ratio not specified.
/// </summary>
public partial record NotSpecifiedRate : IRatioFormat11Choice
{
    public required RateValueType7Code Value { get; init; }
}

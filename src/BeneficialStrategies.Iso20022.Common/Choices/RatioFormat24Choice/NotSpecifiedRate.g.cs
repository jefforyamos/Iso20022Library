﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedRate.  ISO2002 ID# _cti6hJKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RatioFormat24Choice;

/// <summary>
/// Value of the ratio not specified.
/// </summary>
public partial record NotSpecifiedRate : RatioFormat24Choice_
{
    public required RateValueType7Code Value { get; init; }
}

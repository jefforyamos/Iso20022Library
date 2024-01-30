﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _JAnRJWSEEeKFfdK0gKYFLQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FractionDispositionType19Choice;

/// <summary>
/// Standard code to specify how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
public partial record Code : IFractionDispositionType19Choice
{
    public required FractionDispositionType8Code Value { get; init; }
}

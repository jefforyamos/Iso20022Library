﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _c5Lh_ZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FractionDispositionType32Choice;

/// <summary>
/// Standard code to specify how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
public partial record Code : IFractionDispositionType32Choice
{
    public required FractionDispositionType9Code Value { get; init; }
}

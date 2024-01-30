﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ozHvw_YREd-STaetCa3CBw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FractionDispositionType12Choice;

/// <summary>
/// Standard code to specify how fractions resulting from derived securities will be processed or how prorated decisions will be rounding, if provided with a pro ration rate.
/// </summary>
public partial record Code : IFractionDispositionType12Choice
{
    public required FractionDispositionType7Code Value { get; init; }
}

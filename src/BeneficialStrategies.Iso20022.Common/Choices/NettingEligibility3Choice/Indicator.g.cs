﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Indicator.  ISO2002 ID# _Aac80tokEeC60axPepSq7g_-876914956.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NettingEligibility3Choice;

/// <summary>
/// Specifies whether the settlement transaction is eligible for netting.
/// </summary>
public partial record Indicator : NettingEligibility3Choice_
{
    public required IsoYesNoIndicator Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _r_ZgwLaSEeiN--kDwanlkA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionFeaturesFormat25Choice;

/// <summary>
/// Standard code to specify the features that may apply to a corporate action option.
/// </summary>
public partial record Code : IOptionFeaturesFormat25Choice
{
    public required OptionFeatures12Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _z-bBu_onEeCM181g5EbUXw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionFeaturesFormat9Choice;

/// <summary>
/// Standard code to specify the features that may apply to a corporate action option.
/// </summary>
public partial record Code : OptionFeaturesFormat9Choice_
{
    public required OptionFeatures4Code Value { get; init; }
}

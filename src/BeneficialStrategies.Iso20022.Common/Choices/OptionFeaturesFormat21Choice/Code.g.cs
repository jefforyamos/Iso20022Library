﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _c5XvR5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OptionFeaturesFormat21Choice;

/// <summary>
/// Standard code to specify the features that may apply to a corporate action option.
/// </summary>
public partial record Code : OptionFeaturesFormat21Choice_
{
    public required OptionFeatures8Code Value { get; init; }
}

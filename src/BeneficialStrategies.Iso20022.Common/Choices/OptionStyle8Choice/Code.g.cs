﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _hDvSQTq2EeWQ1Y7f8kds2A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OptionStyle8Choice;

/// <summary>
/// Option style expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IOptionStyle8Choice
{
    public required OptionStyle2Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _c4ciiZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionNarrative4Choice;

/// <summary>
/// Standard code to specify the narrative type of the message.
/// </summary>
public partial record Code : ICorporateActionNarrative4Choice
{
    public required CorporateActionNarrative1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _-lkSaAVSEeqjd8n6wD9JVw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType96Choice;

/// <summary>
/// Event type expressed as a code.
/// </summary>
public partial record Code : ICorporateActionEventType96Choice
{
    public required CorporateActionEventType30Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q4g6Y9p-Ed-ak6NoX_4Aeg_489319319.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType3Choice;

/// <summary>
/// Event types expressed as a code.
/// </summary>
public partial record Code : ICorporateActionEventType3Choice
{
    public required CorporateActionEventType6Code Value { get; init; }
}

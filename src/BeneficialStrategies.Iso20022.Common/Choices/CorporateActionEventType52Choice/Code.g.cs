﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _JSBjE4r8EeaNFeVGetd6Xw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType52Choice;

/// <summary>
/// Event types expressed as a code.
/// </summary>
public partial record Code : ICorporateActionEventType52Choice
{
    public required CorporateActionEventType20Code Value { get; init; }
}

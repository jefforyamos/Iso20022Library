﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cel31ZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionEventType36Choice;

/// <summary>
/// Event types expressed as a code.
/// </summary>
public partial record Code : ICorporateActionEventType36Choice
{
    public required CorporateActionEventType15Code Value { get; init; }
}

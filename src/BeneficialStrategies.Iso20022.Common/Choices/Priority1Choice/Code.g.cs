﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _SP24wX_REeiik6YN_dzlEA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Priority1Choice;

/// <summary>
/// Priority code, in a coded form.
/// </summary>
public partial record Code : IPriority1Choice
{
    public required Priority5Code Value { get; init; }
}

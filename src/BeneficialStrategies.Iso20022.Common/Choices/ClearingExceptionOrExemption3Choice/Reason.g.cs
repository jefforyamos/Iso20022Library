﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _AjSxcZPuEey0rJ3Gl6WZVA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingExceptionOrExemption3Choice;

/// <summary>
/// No reason to report or no reason available to report.
/// </summary>
public partial record Reason : IClearingExceptionOrExemption3Choice
{
    public required NoReasonCode Value { get; init; }
}

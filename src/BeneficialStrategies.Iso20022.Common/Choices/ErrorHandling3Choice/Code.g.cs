﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RN4hYXhdEeidzqjNEfehPg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ErrorHandling3Choice;

/// <summary>
/// Specification of the error, in coded form.
/// </summary>
public partial record Code : IErrorHandling3Choice
{
    public required ExternalSystemErrorHandling1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _jwIVARbvEeOy-PlRuFSUzQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ErrorHandling2Choice;

/// <summary>
/// Specification of the error, in coded form.
/// </summary>
public partial record Code : IErrorHandling2Choice
{
    public required ErrorHandling1Code Value { get; init; }
}

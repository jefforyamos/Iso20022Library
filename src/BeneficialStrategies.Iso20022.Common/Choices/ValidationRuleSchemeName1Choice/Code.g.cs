﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _kAjWZNjGEeSD0e0ybx5L5Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ValidationRuleSchemeName1Choice;

/// <summary>
/// Name of the identification scheme, in a coded form as published in an external list.
/// </summary>
public partial record Code : IValidationRuleSchemeName1Choice
{
    public required ExternalValidationRuleIdentification1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q0VlANp-Ed-ak6NoX_4Aeg_1777291305.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DeadlineCode1Choice;

/// <summary>
/// Standard code to specify the reference date of a corporate action.
/// </summary>
public partial record Code : DeadlineCode1Choice_
{
    public required CorporateActionDeadline1Code Value { get; init; }
}

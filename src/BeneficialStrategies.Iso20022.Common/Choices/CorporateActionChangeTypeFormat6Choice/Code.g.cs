﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _42kR4UGTEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionChangeTypeFormat6Choice;

/// <summary>
/// Standard code to specify the type of changes.
/// </summary>
public partial record Code : ICorporateActionChangeTypeFormat6Choice
{
    public required CorporateActionChangeType2Code Value { get; init; }
}

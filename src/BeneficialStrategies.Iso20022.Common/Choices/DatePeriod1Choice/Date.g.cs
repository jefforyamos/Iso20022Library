﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Date.  ISO2002 ID# _kaGgVJ79EeOieb-y7x0pFg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DatePeriod1Choice;

/// <summary>
/// Time span defined by a specific date.
/// </summary>
public partial record Date : IDatePeriod1Choice
{
    public required IsoISODate Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ToDate.  ISO2002 ID# _aQotY4aAEee8r9VKRbnJSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DatePeriodSearch1Choice;

/// <summary>
/// End date of the range.
/// </summary>
public partial record ToDate : IDatePeriodSearch1Choice
{
    public required IsoISODate Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FromDate.  ISO2002 ID# _aQotYYaAEee8r9VKRbnJSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DatePeriodSearch1Choice;

/// <summary>
/// Start date of the range.
/// </summary>
public partial record FromDate : DatePeriodSearch1Choice_
{
    public required IsoISODate Value { get; init; }
}

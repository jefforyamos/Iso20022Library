﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NotSpecifiedDate.  ISO2002 ID# _7oUpo-WdEeevU7McUP3D1w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat56Choice;

/// <summary>
/// The date is not specified, eg, the date is unknown.
/// </summary>
public partial record NotSpecifiedDate : IDateFormat56Choice
{
    public required DateType6Code Value { get; init; }
}

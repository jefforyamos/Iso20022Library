﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q2uKptp-Ed-ak6NoX_4Aeg_284746717.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DateCode4Choice;

/// <summary>
/// Standard code to specify the type of date.
/// </summary>
public partial record Code : IDateCode4Choice
{
    public required DateType7Code Value { get; init; }
}

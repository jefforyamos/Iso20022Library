﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for YearMonthDay.  ISO2002 ID# _xXmZw5BrEeaGiLsfv6g8MA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat42Choice;

/// <summary>
/// Year, month and day.
/// </summary>
public partial record YearMonthDay : IDateFormat42Choice
{
    public required IsoISODate Value { get; init; }
}

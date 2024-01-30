﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DateCodeAndTime.  ISO2002 ID# _MMyiK0EEEeWVgfuHGaKtRQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat32Choice;

/// <summary>
/// Specifies a date code and a time.
/// </summary>
public partial record DateCodeAndTime : IDateFormat32Choice
{
    #nullable enable
    /// <summary>
    /// Specifies the type of date.
    /// </summary>
    public required IDateCode21Choice DateCode { get; init; } 
    /// <summary>
    /// Specifies the time.
    /// </summary>
    public required IsoISOTime Time { get; init; } 
    #nullable disable
}

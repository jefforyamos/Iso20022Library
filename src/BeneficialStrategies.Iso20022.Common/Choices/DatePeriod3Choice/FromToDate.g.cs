﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FromToDate.  ISO2002 ID# _A-Um5YwDEei289CGNqs21g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DatePeriod3Choice;

/// <summary>
/// Range of time between a start date and an end date.
/// </summary>
public partial record FromToDate : IDatePeriod3Choice
{
    #nullable enable
    /// <summary>
    /// Start date of the range.
    /// </summary>
    public required IsoISODate FromDate { get; init; } 
    /// <summary>
    /// End date of the range.
    /// </summary>
    public required IsoISODate ToDate { get; init; } 
    #nullable disable
}

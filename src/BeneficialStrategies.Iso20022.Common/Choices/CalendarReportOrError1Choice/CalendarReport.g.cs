﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CalendarReport.  ISO2002 ID# _dVcQ44m7Eeipw6hHPgB4Sw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CalendarReportOrError1Choice;

/// <summary>
/// Provides the calendar information related to the system.
/// </summary>
public partial record CalendarReport : ICalendarReportOrError1Choice
{
    #nullable enable
    /// <summary>
    /// Identification of the service or system for which the calendar information is provided.
    /// </summary>
    public SystemAndCurrency1? Service { get; init; } 
    /// <summary>
    /// Requested information on the calendar or business error report when information has not been found.
    /// </summary>
    public required ICalendarOrBusinessError1Choice CalendarOrError { get; init; } 
    #nullable disable
}

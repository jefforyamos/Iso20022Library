﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Date.  ISO2002 ID# _l61PQbQVEeemgtANb5gbCw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateOrDateTimePeriod2Choice;

/// <summary>
/// Period expressed with dates.
/// </summary>
public partial record Date : DateOrDateTimePeriod2Choice_
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

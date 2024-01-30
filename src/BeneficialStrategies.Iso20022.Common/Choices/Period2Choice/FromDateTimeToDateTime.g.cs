﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FromDateTimeToDateTime.  ISO2002 ID# _T5exEtp-Ed-ak6NoX_4Aeg_-1058335325.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Period2Choice;

/// <summary>
/// Time span defined by a start date and time, and an end date and time.
/// </summary>
public partial record FromDateTimeToDateTime : IPeriod2Choice
{
    #nullable enable
    /// <summary>
    /// Date and time at which the range starts.
    /// </summary>
    public required IsoISODateTime FromDateTime { get; init; } 
    /// <summary>
    /// Date and time at which the range ends.
    /// </summary>
    public required IsoISODateTime ToDateTime { get; init; } 
    #nullable disable
}

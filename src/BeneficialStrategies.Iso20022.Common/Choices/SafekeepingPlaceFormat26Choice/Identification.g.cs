﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Identification.  ISO2002 ID# _Vyh5AZqLEeWcAIE4lEkF_Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat26Choice;

/// <summary>
/// Place of safekeeping expressed as a code and a narrative description.
/// </summary>
public partial record Identification : ISafekeepingPlaceFormat26Choice
{
    #nullable enable
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    public IsoRestrictedFINXMax30Text? IdentificationValue { get; init; } 
    #nullable disable
}

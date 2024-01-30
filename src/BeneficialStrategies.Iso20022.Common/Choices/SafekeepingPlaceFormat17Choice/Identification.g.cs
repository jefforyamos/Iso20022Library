﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Identification.  ISO2002 ID# _cj_8g5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat17Choice;

/// <summary>
/// Place of safekeeping expressed as a code and a narrative description.
/// </summary>
public partial record Identification : ISafekeepingPlaceFormat17Choice
{
    #nullable enable
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    public required SafekeepingPlace3Code SafekeepingPlaceType { get; init; } 
    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    public IsoRestrictedFINXMax30Text? IdentificationValue { get; init; } 
    #nullable disable
}

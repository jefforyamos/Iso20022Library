﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TypeAndIdentification.  ISO2002 ID# _cj_8k5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat17Choice;

/// <summary>
/// Place of safekeeping expressed with a type and identification.
/// </summary>
public partial record TypeAndIdentification : ISafekeepingPlaceFormat17Choice
{
    #nullable enable
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    public required SafekeepingPlace1Code SafekeepingPlaceType { get; init; } 
    /// <summary>
    /// Place of safekeeping.
    /// </summary>
    public required IsoAnyBICIdentifier Identification { get; init; } 
    #nullable disable
}

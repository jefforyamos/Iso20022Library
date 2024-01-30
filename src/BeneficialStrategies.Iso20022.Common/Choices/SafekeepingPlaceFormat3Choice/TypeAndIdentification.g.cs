﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TypeAndIdentification.  ISO2002 ID# _SfoCIdp-Ed-ak6NoX_4Aeg_-955186209.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat3Choice;

/// <summary>
/// Place of safekeeping expressed with a type and identification.
/// </summary>
public partial record TypeAndIdentification : ISafekeepingPlaceFormat3Choice
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

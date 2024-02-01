﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TypeAndIdentification.  ISO2002 ID# _5V6N4TnTEeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat10Choice;

/// <summary>
/// Place of safekeeping expressed with a type and identification.
/// </summary>
public partial record TypeAndIdentification : SafekeepingPlaceFormat10Choice_
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

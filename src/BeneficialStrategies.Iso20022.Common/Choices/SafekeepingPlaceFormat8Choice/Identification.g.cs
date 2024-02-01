﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Identification.  ISO2002 ID# _k06gIR5iEeWDV95LUQhXCA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat8Choice;

/// <summary>
/// Place of safekeeping expressed as a code and a narrative description.
/// </summary>
public partial record Identification : SafekeepingPlaceFormat8Choice_
{
    #nullable enable
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    public required SafekeepingPlace2Code SafekeepingPlaceType { get; init; } 
    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    public IsoMax35Text? IdentificationValue { get; init; } 
    #nullable disable
}

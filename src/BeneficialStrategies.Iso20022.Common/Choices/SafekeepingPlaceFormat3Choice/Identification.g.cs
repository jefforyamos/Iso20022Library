﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Identification.  ISO2002 ID# _SfeRKtp-Ed-ak6NoX_4Aeg_-955186565.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat3Choice;

/// <summary>
/// Place of safekeeping expressed as a code and a narrative description.
/// </summary>
public partial record Identification : SafekeepingPlaceFormat3Choice_
{
    #nullable enable
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    public required SafekeepingPlace3Code SafekeepingPlaceType { get; init; } 
    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    public IsoMax35Text? IdentificationValue { get; init; } 
    #nullable disable
}

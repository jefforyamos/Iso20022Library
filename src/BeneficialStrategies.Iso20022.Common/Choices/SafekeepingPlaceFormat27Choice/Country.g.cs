﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _lFrrWaWXEeahOrvW2rewGg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat27Choice;

/// <summary>
/// Place of safekeeping expressed with a country code.
/// </summary>
public partial record Country : SafekeepingPlaceFormat27Choice_
{
    public required CountryCode Value { get; init; }
}

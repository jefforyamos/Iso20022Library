﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _SfoCINp-Ed-ak6NoX_4Aeg_-955186660.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat3Choice;

/// <summary>
/// Place of safekeeping expressed with a country code.
/// </summary>
public partial record Country : ISafekeepingPlaceFormat3Choice
{
    public required CountryCode Value { get; init; }
}

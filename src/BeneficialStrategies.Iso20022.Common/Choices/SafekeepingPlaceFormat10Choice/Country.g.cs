﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _5V6N2TnTEeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat10Choice;

/// <summary>
/// Place of safekeeping expressed with a country code.
/// </summary>
public partial record Country : SafekeepingPlaceFormat10Choice_
{
    public required CountryCode Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _cj_8i5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat17Choice;

/// <summary>
/// Place of safekeeping expressed with a country code.
/// </summary>
public partial record Country : SafekeepingPlaceFormat17Choice_
{
    public required CountryCode Value { get; init; }
}

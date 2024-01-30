﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _qhzzw8g4Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Branch6Choice;

/// <summary>
/// Code of a country where the registered office of the branch counterparty is located or country of residence in case that the branch counterparty is a natural person.
/// </summary>
public partial record Country : IBranch6Choice
{
    public required CountryCode Value { get; init; }
}

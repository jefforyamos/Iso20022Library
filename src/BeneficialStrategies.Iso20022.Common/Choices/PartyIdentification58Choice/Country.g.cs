﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _v3FPCAgeEeCVlvYcV4HKqQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification58Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record Country : IPartyIdentification58Choice
{
    public required CountryCode Value { get; init; }
}

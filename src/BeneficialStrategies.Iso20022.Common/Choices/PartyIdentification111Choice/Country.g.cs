﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _ckEN8ZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification111Choice;

/// <summary>
/// Unique and unambiguous way to identify an organisation.
/// </summary>
public partial record Country : IPartyIdentification111Choice
{
    public required CountryCode Value { get; init; }
}

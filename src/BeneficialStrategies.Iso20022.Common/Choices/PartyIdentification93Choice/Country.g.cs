﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Country.  ISO2002 ID# _blbCyTqmEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification93Choice;

/// <summary>
/// Country in which a person resides (the place of a person's home). In the case of a company, it is the country from which the affairs of that company are directed.
/// </summary>
public partial record Country : IPartyIdentification93Choice
{
    public required CountryCode Value { get; init; }
}

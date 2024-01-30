﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TaxIdentificationNumber.  ISO2002 ID# _jWaFQiGYEeWKAaDJcYGKLw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification96Choice;

/// <summary>
/// Number assigned by a tax authority to an entity.
/// </summary>
public partial record TaxIdentificationNumber : IPartyIdentification96Choice
{
    public required IsoMax35Text Value { get; init; }
}

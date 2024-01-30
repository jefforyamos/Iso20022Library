﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TaxIdentificationNumber.  ISO2002 ID# _QRUXgdp-Ed-ak6NoX_4Aeg_-1819499292.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification5Choice;

/// <summary>
/// Number assigned by a tax authority to an entity.
/// </summary>
public partial record TaxIdentificationNumber : IPartyIdentification5Choice
{
    public required IsoMax35Text Value { get; init; }
}

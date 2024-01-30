﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BIC.  ISO2002 ID# _QQIEt9p-Ed-ak6NoX_4Aeg_-186892124.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification30Choice;

/// <summary>
/// Unique and unambiguous identifier for an organisation that is allocated by an institution.
/// </summary>
public partial record BIC : IPartyIdentification30Choice
{
    public required IsoBICIdentifier Value { get; init; }
}

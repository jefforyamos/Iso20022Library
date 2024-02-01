﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountServicerTransactionIdentification.  ISO2002 ID# _d_pEcTi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References78Choice;

/// <summary>
/// Unambiguous identification of the transaction as known by the account servicer.
/// </summary>
public partial record AccountServicerTransactionIdentification : References78Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for AccountServicerTransactionIdentification.  ISO2002 ID# _diXSuzi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References76Choice;

/// <summary>
/// Unambiguous identification of the transaction as known by the account servicer.
/// </summary>
public partial record AccountServicerTransactionIdentification : IReferences76Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CounterpartyMarketInfrastructureTransactionIdentification.  ISO2002 ID# _diXSyzi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References76Choice;

/// <summary>
/// Identification of a counterparty transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
/// </summary>
public partial record CounterpartyMarketInfrastructureTransactionIdentification : IReferences76Choice
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}

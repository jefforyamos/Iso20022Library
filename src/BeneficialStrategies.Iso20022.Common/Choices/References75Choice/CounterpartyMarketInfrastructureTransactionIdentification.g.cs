﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CounterpartyMarketInfrastructureTransactionIdentification.  ISO2002 ID# _ccpnrTi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References75Choice;

/// <summary>
/// Identification of a counterparty transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
/// </summary>
public partial record CounterpartyMarketInfrastructureTransactionIdentification : References75Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}

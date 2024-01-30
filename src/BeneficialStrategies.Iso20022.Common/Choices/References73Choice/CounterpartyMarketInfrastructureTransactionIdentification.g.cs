﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CounterpartyMarketInfrastructureTransactionIdentification.  ISO2002 ID# _LPWOcSgUEeym1_Zp1BTvEw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References73Choice;

/// <summary>
/// Identification of a counterparty transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
/// </summary>
public partial record CounterpartyMarketInfrastructureTransactionIdentification : IReferences73Choice
{
    public required IsoMax35Text Value { get; init; }
}

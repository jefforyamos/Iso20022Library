﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarketInfrastructureTransactionIdentification.  ISO2002 ID# _2ThUozt4EeW638lNyHKv7A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References46Choice;

/// <summary>
/// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
/// </summary>
public partial record MarketInfrastructureTransactionIdentification : IReferences46Choice
{
    public required IsoMax35Text Value { get; init; }
}

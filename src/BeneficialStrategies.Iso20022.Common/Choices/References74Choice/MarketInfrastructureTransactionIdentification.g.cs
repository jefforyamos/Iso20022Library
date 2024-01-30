﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarketInfrastructureTransactionIdentification.  ISO2002 ID# _SiFNkSgaEey2k_sfZmJz4g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References74Choice;

/// <summary>
/// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
/// </summary>
public partial record MarketInfrastructureTransactionIdentification : IReferences74Choice
{
    public required IsoMax35Text Value { get; init; }
}

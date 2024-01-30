﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MarketInfrastructureTransactionIdentification.  ISO2002 ID# _mKuVRf7xEeCvPoRGOxRobQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References27Choice;

/// <summary>
/// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
/// </summary>
public partial record MarketInfrastructureTransactionIdentification : IReferences27Choice
{
    public required IsoMax35Text Value { get; init; }
}

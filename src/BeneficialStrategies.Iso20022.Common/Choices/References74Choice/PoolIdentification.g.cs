﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PoolIdentification.  ISO2002 ID# _SiFNmSgaEey2k_sfZmJz4g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.References74Choice;

/// <summary>
/// Collective reference identifying a set of messages.
/// </summary>
public partial record PoolIdentification : IReferences74Choice
{
    public required IsoMax35Text Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TradeIdentification.  ISO2002 ID# _SiFNqSgaEey2k_sfZmJz4g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References74Choice;

/// <summary>
/// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
/// </summary>
public partial record TradeIdentification : IReferences74Choice
{
    public required IsoMax52Text Value { get; init; }
}

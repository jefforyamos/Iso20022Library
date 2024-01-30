﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for TradeIdentification.  ISO2002 ID# _diXS3Ti8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References76Choice;

/// <summary>
/// Reference assigned to the trade by the investor or the trading party. This reference will be used throughout the trade life cycle to access/update the trade details.
/// </summary>
public partial record TradeIdentification : IReferences76Choice
{
    public required IsoRestrictedFINXMax52Text Value { get; init; }
}

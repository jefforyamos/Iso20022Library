﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PoolIdentification.  ISO2002 ID# _ccpnqTi8Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References75Choice;

/// <summary>
/// Collective reference identifying a set of messages.
/// </summary>
public partial record PoolIdentification : References75Choice_
{
    public required IsoRestrictedFINXMax16Text Value { get; init; }
}

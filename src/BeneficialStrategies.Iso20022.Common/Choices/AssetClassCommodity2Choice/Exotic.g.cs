﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Exotic.  ISO2002 ID# _BzEmPSYyEeWHeosc_5RQEw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice;

/// <summary>
/// Indicates the exotic type of commodities.
/// </summary>
public partial record Exotic : IAssetClassCommodity2Choice
{
    public required NoReasonCode Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Index.  ISO2002 ID# _BzEmPCYyEeWHeosc_5RQEw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity2Choice;

/// <summary>
/// Indicates the index type of commodities.
/// </summary>
public partial record Index : IAssetClassCommodity2Choice
{
    public required NoReasonCode Value { get; init; }
}

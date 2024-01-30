﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Inflation.  ISO2002 ID# _lThddXvyEeanCNPcMT7sSg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity3Choice;

/// <summary>
/// Inflation commodities.
/// </summary>
public partial record Inflation : IAssetClassCommodity3Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType12Code BaseProduct { get; init; } 
    #nullable disable
}

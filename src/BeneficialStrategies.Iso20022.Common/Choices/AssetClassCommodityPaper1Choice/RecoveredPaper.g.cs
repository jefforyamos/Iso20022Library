﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RecoveredPaper.  ISO2002 ID# _itCYoFryEeWN79Bl6BUd3g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPaper1Choice;

/// <summary>
/// Recovered paper commodity derivative.
/// </summary>
public partial record RecoveredPaper : IAssetClassCommodityPaper1Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType8Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public AssetClassSubProductType38Code? SubProduct { get; init; } 
    #nullable disable
}

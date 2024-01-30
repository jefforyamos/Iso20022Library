﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for UreaAndAmmoniumNitrate.  ISO2002 ID# _xb6EAFr2EeWN79Bl6BUd3g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFertilizer1Choice;

/// <summary>
/// Urea and ammonium nitrate fertilizer commodity derivative.
/// </summary>
public partial record UreaAndAmmoniumNitrate : IAssetClassCommodityFertilizer1Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType5Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType44Code SubProduct { get; init; } 
    #nullable disable
}

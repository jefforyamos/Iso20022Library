﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Plastic.  ISO2002 ID# __aGQgGs5EeW9oI9ZdgWHPQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPolypropylene1Choice;

/// <summary>
/// Plastic commodity derivative.
/// </summary>
public partial record Plastic : IAssetClassCommodityPolypropylene1Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType9Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public AssetClassSubProductType18Code? SubProduct { get; init; } 
    #nullable disable
}

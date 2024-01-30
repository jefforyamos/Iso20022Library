﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ContainerBoard.  ISO2002 ID# __n-Wgbv7EeiLRYqS-r-R-A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPaper3Choice;

/// <summary>
/// Container board commodity derivative.
/// </summary>
public partial record ContainerBoard : IAssetClassCommodityPaper3Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType8Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public AssetClassSubProductType35Code? SubProduct { get; init; } 
    #nullable disable
}

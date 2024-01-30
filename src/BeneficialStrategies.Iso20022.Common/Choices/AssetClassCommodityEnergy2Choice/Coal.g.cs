﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Coal.  ISO2002 ID# _x4yAd7vsEeiLRYqS-r-R-A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnergy2Choice;

/// <summary>
/// Definition of Coal energy commodity derivative.
/// </summary>
public partial record Coal : IAssetClassCommodityEnergy2Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType2Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType24Code SubProduct { get; init; } 
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Oil.  ISO2002 ID# _x4yAdbvsEeiLRYqS-r-R-A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnergy2Choice;

/// <summary>
/// Definition of Oil energy commodity derivative.
/// </summary>
public partial record Oil : IAssetClassCommodityEnergy2Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType2Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType8Code SubProduct { get; init; } 
    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    public required AssetClassDetailedSubProductType32Code AdditionalSubProduct { get; init; } 
    #nullable disable
}

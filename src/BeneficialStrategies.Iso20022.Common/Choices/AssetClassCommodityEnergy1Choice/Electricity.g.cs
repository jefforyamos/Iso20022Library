﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Electricity.  ISO2002 ID# _pBoTaA2nEeW72qLtWESimw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnergy1Choice;

/// <summary>
/// Definition of Electricity energy commodity derivative.
/// </summary>
public partial record Electricity : IAssetClassCommodityEnergy1Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType2Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType6Code SubProduct { get; init; } 
    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    public required AssetClassDetailedSubProductType5Code AdditionalSubProduct { get; init; } 
    #nullable disable
}

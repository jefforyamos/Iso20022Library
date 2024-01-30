﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Seafood.  ISO2002 ID# _xG_LrU8SEe2PGo0mhYCh1g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityAgricultural6Choice;

/// <summary>
/// Seafood agricultural commodity derivative.
/// </summary>
public partial record Seafood : IAssetClassCommodityAgricultural6Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType1Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public AssetClassSubProductType23Code? SubProduct { get; init; } 
    #nullable disable
}

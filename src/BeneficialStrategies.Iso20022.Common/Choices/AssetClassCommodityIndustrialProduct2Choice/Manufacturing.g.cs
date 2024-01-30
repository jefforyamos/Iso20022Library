﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Manufacturing.  ISO2002 ID# _OTrSExZZEe2QNcZTDeoKnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityIndustrialProduct2Choice;

/// <summary>
/// Manufacturing related industrial product commodity derivative.
/// </summary>
public partial record Manufacturing : IAssetClassCommodityIndustrialProduct2Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType6Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public AssetClassSubProductType34Code? SubProduct { get; init; } 
    #nullable disable
}

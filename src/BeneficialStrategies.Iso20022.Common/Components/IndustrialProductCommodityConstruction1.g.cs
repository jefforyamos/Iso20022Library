﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for IndustrialProductCommodityConstruction1.  ISO2002 ID# _EBzfkFrgEeWN79Bl6BUd3g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of an industrial product derivative of type construction.
/// </summary>
public partial record IndustrialProductCommodityConstruction1
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType6Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public AssetClassSubProductType33Code? SubProduct { get; init; } 
    
    #nullable disable
}

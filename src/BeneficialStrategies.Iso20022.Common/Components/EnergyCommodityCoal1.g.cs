﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnergyCommodityCoal1.  ISO2002 ID# _4PZ0EFrVEeWN79Bl6BUd3g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of an energy derivative of type coal.
/// </summary>
public partial record EnergyCommodityCoal1
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

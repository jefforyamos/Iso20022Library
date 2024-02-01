﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CarbonRelated.  ISO2002 ID# _g7vTtbvwEeiLRYqS-r-R-A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityEnvironmental2Choice;

/// <summary>
/// Carbon related environmental commodity derivative.
/// </summary>
public partial record CarbonRelated : AssetClassCommodityEnvironmental2Choice_
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType3Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType29Code SubProduct { get; init; } 
    #nullable disable
}

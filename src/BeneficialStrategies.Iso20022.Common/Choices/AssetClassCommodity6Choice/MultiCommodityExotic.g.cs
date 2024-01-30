﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for MultiCommodityExotic.  ISO2002 ID# _1bgUJxZXEe2QNcZTDeoKnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity6Choice;

/// <summary>
/// Multi Commodity Exotic
/// </summary>
public partial record MultiCommodityExotic : IAssetClassCommodity6Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType13Code BaseProduct { get; init; } 
    #nullable disable
}

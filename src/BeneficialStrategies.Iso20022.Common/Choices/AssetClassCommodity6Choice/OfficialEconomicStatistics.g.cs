﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OfficialEconomicStatistics.  ISO2002 ID# _1bgUKRZXEe2QNcZTDeoKnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity6Choice;

/// <summary>
/// Official Economic Statistics commodities.
/// </summary>
public partial record OfficialEconomicStatistics : IAssetClassCommodity6Choice
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType14Code BaseProduct { get; init; } 
    #nullable disable
}

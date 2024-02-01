﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ContainerShip.  ISO2002 ID# _AXue4vwgEeW4Wthd0Ze_kA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityFreight1Choice;

/// <summary>
/// Container ship freight commodity derivative.
/// </summary>
public partial record ContainerShip : AssetClassCommodityFreight1Choice_
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType4Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType46Code SubProduct { get; init; } 
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NonPrecious.  ISO2002 ID# _D1rdVA2rEeW72qLtWESimw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityMetal1Choice;

/// <summary>
/// Non-precious metal commodity derivative.
/// </summary>
public partial record NonPrecious : AssetClassCommodityMetal1Choice_
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType7Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public required AssetClassSubProductType15Code SubProduct { get; init; } 
    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    public required AssetClassDetailedSubProductType10Code AdditionalSubProduct { get; init; } 
    #nullable disable
}

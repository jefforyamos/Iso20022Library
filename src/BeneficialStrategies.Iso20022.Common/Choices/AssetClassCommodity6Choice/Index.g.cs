﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Index.  ISO2002 ID# _lKkAEE7JEe2PGo0mhYCh1g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodity6Choice;

/// <summary>
/// Indicates the index type of commodities.
/// </summary>
public partial record Index : AssetClassCommodity6Choice_
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType16Code BaseProduct { get; init; } 
    #nullable disable
}

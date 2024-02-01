﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RecoveredPaper.  ISO2002 ID# _FsdvNxZaEe2QNcZTDeoKnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AssetClassCommodityPaper4Choice;

/// <summary>
/// Recovered paper commodity derivative.
/// </summary>
public partial record RecoveredPaper : AssetClassCommodityPaper4Choice_
{
    #nullable enable
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    public required AssetClassProductType8Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    public AssetClassSubProductType49Code? SubProduct { get; init; } 
    #nullable disable
}

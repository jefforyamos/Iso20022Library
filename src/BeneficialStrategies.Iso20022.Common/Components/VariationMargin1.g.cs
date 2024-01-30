﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for VariationMargin1.  ISO2002 ID# _UnE22tp-Ed-ak6NoX_4Aeg_12968577.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Elements used to calculate the collateral margin call for the variation margin.
/// </summary>
public partial record VariationMargin1
{
    #nullable enable
    
    /// <summary>
    /// Amount of unsecured exposure a counterparty will accept before issuing a margin call in the base currency.
    /// </summary>
    public required IsoActiveCurrencyAndAmount ThresholdAmount { get; init; } 
    /// <summary>
    /// Specifies if the threshold amount is secured or unsecured.
    /// </summary>
    public ThresholdType1Code? ThresholdType { get; init; } 
    /// <summary>
    /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of variation margin).
    /// </summary>
    public required IsoActiveCurrencyAndAmount MinimumTransferAmount { get; init; } 
    /// <summary>
    /// Amount specified to avoid the need to transfer uneven amounts of collateral.
    /// </summary>
    public required IsoActiveCurrencyAndAmount RoundingAmount { get; init; } 
    /// <summary>
    /// Defines how the rounding amount was applied in the calculation. For example, should the amount of collateral required be rounded up, down, to the closer integral multiple specified or not rounded.
    /// </summary>
    public required RoundingMethod1Code RoundingMethod { get; init; } 
    
    #nullable disable
}

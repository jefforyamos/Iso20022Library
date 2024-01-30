﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for SegregatedIndependentAmountMargin.  ISO2002 ID# _QmogNNp-Ed-ak6NoX_4Aeg_1633105891.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.MarginTerms1Choice;

/// <summary>
/// Elements used to calculate the collateral margin call for the segregated independent amount.
/// </summary>
public partial record SegregatedIndependentAmountMargin : IMarginTerms1Choice
{
    #nullable enable
    /// <summary>
    /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of segregated independent amount).
    /// </summary>
    public required IsoActiveCurrencyAndAmount MinimumTransferAmount { get; init; } 
    /// <summary>
    /// Amount specified to avoid the need to transfer uneven amounts of independent amount collateral.
    /// </summary>
    public IsoActiveCurrencyAndAmount? RoundingAmount { get; init; } 
    /// <summary>
    /// Defines how the rounding amount was applied in the calculation. For example, should the amount of collateral required be rounded up, down, to the closer integral multiple specified or not rounded.
    /// </summary>
    public RoundingMethod1Code? RoundingMethod { get; init; } 
    #nullable disable
}

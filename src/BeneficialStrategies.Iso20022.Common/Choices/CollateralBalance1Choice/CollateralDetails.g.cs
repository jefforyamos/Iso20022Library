﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CollateralDetails.  ISO2002 ID# _UnXxydp-Ed-ak6NoX_4Aeg_1050208503.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CollateralBalance1Choice;

/// <summary>
/// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, for the variation margin and optionally the segregated independent amount.
/// </summary>
public partial record CollateralDetails : ICollateralBalance1Choice
{
    #nullable enable
    /// <summary>
    /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, against the variation margin.
    /// </summary>
    public required MarginCollateral1 VariationMargin { get; init; } 
    /// <summary>
    /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, against the segregated independent amount.
    /// </summary>
    public MarginCollateral1? SegregatedIndependentAmount { get; init; } 
    #nullable disable
}

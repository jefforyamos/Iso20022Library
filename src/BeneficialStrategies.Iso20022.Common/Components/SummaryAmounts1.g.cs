﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SummaryAmounts1.  ISO2002 ID# _vVx-YqMOEeCojJW5vEuTEQ_933225086.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides amounts taken in to account to calculate the collateral position.
/// </summary>
public partial record SummaryAmounts1
{
    #nullable enable
    
    /// <summary>
    /// Amount of unsecured exposure a counterparty will accept before issuing a margin call in the base currency.
    /// </summary>
    public IsoActiveCurrencyAndAmount? ThresholdAmount { get; init; } 
    /// <summary>
    /// Specifies if the threshold amount is secured or unsecured.
    /// </summary>
    public ThresholdType1Code? ThresholdType { get; init; } 
    /// <summary>
    /// Total value of posted collateral (pre-haircut) held by the taker.
    /// </summary>
    public IsoActiveCurrencyAndAmount? PreHaircutCollateralValue { get; init; } 
    /// <summary>
    /// Total amount of collateral required (unrounded).
    /// </summary>
    public IsoActiveCurrencyAndAmount? AdjustedExposure { get; init; } 
    /// <summary>
    /// Total amount of collateral required (rounded).
    /// </summary>
    public IsoActiveCurrencyAndAmount? CollateralRequired { get; init; } 
    /// <summary>
    /// Minimum amount to pay/receive as specified in the agreement in the base currency (to avoid the need to transfer an inconveniently small amount of collateral).
    /// </summary>
    public IsoActiveCurrencyAndAmount? MinimumTransferAmount { get; init; } 
    /// <summary>
    /// Amount specified to avoid the need to transfer uneven amounts of collateral.
    /// </summary>
    public IsoActiveCurrencyAndAmount? RoundingAmount { get; init; } 
    /// <summary>
    /// Exposure value at previous valuation.
    /// </summary>
    public IsoActiveCurrencyAndAmount? PreviousExposureValue { get; init; } 
    /// <summary>
    /// Value of collateral at previous valuation.
    /// </summary>
    public IsoActiveCurrencyAndAmount? PreviousCollateralValue { get; init; } 
    /// <summary>
    /// Value of incoming collateral, to be settled.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalPendingIncomingCollateral { get; init; } 
    /// <summary>
    /// Value of outgoing collateral, to be settled.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalPendingOutgoingCollateral { get; init; } 
    /// <summary>
    /// Sum of accrued interest.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalAccruedInterestAmount { get; init; } 
    /// <summary>
    /// Sum of fees/commissions.
    /// </summary>
    public IsoActiveCurrencyAndAmount? TotalFees { get; init; } 
    
    #nullable disable
}

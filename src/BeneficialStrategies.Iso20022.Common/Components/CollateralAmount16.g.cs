﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralAmount16.  ISO2002 ID# _jXJ68RImEeyLzJfz3xPQNA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides details on the collateral valuation.
/// </summary>
[DataContract]
[XmlType]
public partial record CollateralAmount16
{
    #nullable enable
    
    /// <summary>
    /// Total value of posted collateral (post-haircut) expressed in the reporting currency.
    /// </summary>
    [DataMember]
    public required IsoActiveOrHistoricCurrencyAndAmount ValueOfCollateralHeld { get; init; } 
    /// <summary>
    /// Total exposure amount between the giver and taker expressed in the reporting currency.
    /// </summary>
    [DataMember]
    public required IsoActiveOrHistoricCurrencyAndAmount TotalExposure { get; init; } 
    /// <summary>
    /// The difference between the total collateral value and the total collateral required.
    /// </summary>
    [DataMember]
    public AmountAndDirection53? Margin { get; init; } 
    /// <summary>
    /// Collateral is required to cover interest that accrues on the exposure. Margin amount would thus be the difference between collateral required and collateral value (that is COVA).
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? TotalCollateralRequired { get; init; } 
    /// <summary>
    /// Total amount of money accrued interest computed in the case of interest bearing financial instruments.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? TotalAccruedInterest { get; init; } 
    /// <summary>
    /// Total value of own collateral in the reporting currency.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? TotalValueOfOwnCollateral { get; init; } 
    /// <summary>
    /// Total value of reused/rehypotheticated collateral in the reporting currency.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? TotalValueOfReusedCollateral { get; init; } 
    /// <summary>
    /// Total of principals in the reporting currency.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? TotalOfPrincipals { get; init; } 
    /// <summary>
    /// Value of incoming collateral, to be settled in the reporting currency.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralIn { get; init; } 
    /// <summary>
    /// Value of outgoing collateral, to be settled in the reporting currency.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? TotalPendingCollateralOut { get; init; } 
    /// <summary>
    /// Total value of undelivered intended transaction cash amount.
    /// </summary>
    [DataMember]
    public IsoActiveOrHistoricCurrencyAndAmount? TotalCashFailed { get; init; } 
    
    #nullable disable
}

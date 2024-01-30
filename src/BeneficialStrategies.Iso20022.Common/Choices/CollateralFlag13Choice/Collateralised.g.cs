﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Collateralised.  ISO2002 ID# _J_aqIcg5Eeu4ecZgAYuz5w.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CollateralFlag13Choice;

/// <summary>
/// Specifies the details of the collateralised securities.
/// </summary>
public partial record Collateralised : ICollateralFlag13Choice
{
    #nullable enable
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the securities financing transaction.
    /// </summary>
    public IsoISODate? CollateralValueDate { get; init; } 
    /// <summary>
    /// Specification on the type of asset used as collateral.
    /// </summary>
    public CollateralType21? AssetType { get; init; } 
    /// <summary>
    /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
    /// </summary>
    public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; } 
    /// <summary>
    /// Identification of the collateral basket.
    /// </summary>
    public ISecurityIdentification26Choice? BasketIdentifier { get; init; } 
    #nullable disable
}

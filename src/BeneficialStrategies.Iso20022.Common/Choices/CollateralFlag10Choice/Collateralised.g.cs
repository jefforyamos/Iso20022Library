﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Collateralised.  ISO2002 ID# _gI37UQAAEeqefbt-QjTNnA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralFlag10Choice;

/// <summary>
/// Data on collateralised securities.
/// </summary>
public partial record Collateralised : CollateralFlag10Choice_
{
    #nullable enable
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the securities financing transaction.
    /// </summary>
    public IsoISODate? CollateralValueDate { get; init; } 
    /// <summary>
    /// Specification on the type of asset used as collateral.
    /// </summary>
    public CollateralType14? AssetType { get; init; } 
    /// <summary>
    /// Indicates whether the collateral has been provided for a net exposure, rather than for a single transaction.
    /// </summary>
    public IsoTrueFalseIndicator? NetExposureCollateralisationIndicator { get; init; } 
    /// <summary>
    /// Identification of the collateral basket.
    /// </summary>
    public SecurityIdentification26Choice_? BasketIdentifier { get; init; } 
    #nullable disable
}

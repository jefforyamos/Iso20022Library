﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for RepurchaseTrade.  ISO2002 ID# _fMZ5wQAFEeqefbt-QjTNnA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TransactionCollateralData15Choice;

/// <summary>
/// Data on collateral used for the repurchase trade transaction.
/// </summary>
public partial record RepurchaseTrade : ITransactionCollateralData15Choice
{
    #nullable enable
    /// <summary>
    /// Date on which the counterparties contractually agree the exchange of cash, securities, or commodities versus collateral for the opening leg (spot leg) of the transaction.
    /// </summary>
    public IsoISODate? CollateralValueDate { get; init; } 
    /// <summary>
    /// Indication of the type of collateral component.
    /// </summary>
    public CollateralType16? AssetType { get; init; } 
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

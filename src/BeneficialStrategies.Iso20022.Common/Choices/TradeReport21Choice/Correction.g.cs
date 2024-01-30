﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Correction.  ISO2002 ID# _SKn4Zcg2EeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport21Choice;

/// <summary>
/// Indicates that the report is correcting the erroneous data fields of a previously submitted position.
/// </summary>
public partial record Correction : ITradeReport21Choice
{
    #nullable enable
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice message.
    /// </summary>
    public IsoMax140Text? TechnicalRecordIdentification { get; init; } 
    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    public required IsoISODateTime ReportingDateTime { get; init; } 
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    public required IsoISODate EventDate { get; init; } 
    /// <summary>
    /// Data specific to counterparties of the reported transaction.
    /// </summary>
    public required Counterparty39 Counterparty { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    public required IsoMax52Text CollateralPortfolioIdentification { get; init; } 
    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    public PostedMarginOrCollateral4? PostedMarginOrCollateral { get; init; } 
    /// <summary>
    /// Information on received collateral and margin.
    /// </summary>
    public ReceivedMarginOrCollateral4? ReceivedMarginOrCollateral { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}

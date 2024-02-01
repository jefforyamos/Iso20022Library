﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CollateralMarginNew7.  ISO2002 ID# _x5ElUf_mEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies details of the collateral margin data.
/// </summary>
public partial record CollateralMarginNew7
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
    public required Counterparty30 Counterparty { get; init; } 
    /// <summary>
    /// Unique and unambiguous identification of the collateral portfolio.
    /// </summary>
    public required IsoMax52Text CollateralPortfolioIdentification { get; init; } 
    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    public PostedMarginOrCollateral3? PostedMarginOrCollateral { get; init; } 
    /// <summary>
    /// Information on received collateral and margin.
    /// </summary>
    public ReceivedMarginOrCollateral3? ReceivedMarginOrCollateral { get; init; } 
    /// <summary>
    /// List of possible values for TRs reconciliation purposes.
    /// </summary>
    public ReconciliationFlag1? ReconciliationFlag { get; init; } 
    /// <summary>
    /// Contract modification details expressed as an action type and a reporting level type.
    /// </summary>
    public required ContractModification3 ContractModification { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1[] SupplementaryData { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

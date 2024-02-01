﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Error.  ISO2002 ID# _o0KFZVosEe23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeReport31Choice;

/// <summary>
/// Indicates whether transaction was reported by mistake and need to be removed.
/// </summary>
public partial record Error : TradeReport31Choice_
{
    #nullable enable
    /// <summary>
    /// Date and time of submission of the report to the trade repository.
    /// </summary>
    public IsoISODateTime? ReportingTimeStamp { get; init; } 
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    public required TradeCounterpartyReport20 CounterpartyIdentification { get; init; } 
    /// <summary>
    /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
    /// </summary>
    public IsoISODate? EventDate { get; init; } 
    /// <summary>
    /// Choice between a Unique Transaction Identifier (UTI) or a proprietary identifier as agreed with the counterparty. 
    /// </summary>
    public UniqueTransactionIdentifier2Choice_? TransactionIdentification { get; init; } 
    /// <summary>
    /// Information related to collateral agreement existing between counterparties.
    /// </summary>
    public required MarginCollateralReport4 Collateral { get; init; } 
    /// <summary>
    /// Information on posted collateral and margin.
    /// </summary>
    public PostedMarginOrCollateral6? PostedMarginOrCollateral { get; init; } 
    /// <summary>
    /// Information on received collateral and margin.
    /// </summary>
    public ReceivedMarginOrCollateral6? ReceivedMarginOrCollateral { get; init; } 
    /// <summary>
    /// Indicates if a counterparty rating trigger is agreed by the counterparties for the collateral posted by the reporting counterparty.
    /// Usage: If the element is not present, the CounterpartyRatingTrigger is False.
    /// </summary>
    public IsoTrueFalseIndicator? CounterpartyRatingTriggerIndicator { get; init; } 
    /// <summary>
    /// Indicates if a counterparty rating trigger includes a threshold that increases collateral requirements when the counterparty falls below the single-A rating or equivalent.
    /// Usage: If the CounterpartyRatingTrigger indicator is false, this element is omitted.
    /// </summary>
    public IsoTrueFalseIndicator? CounterpartyRatingThresholdIndicator { get; init; } 
    /// <summary>
    /// Specifies technical attributes of the message.
    /// </summary>
    public TechnicalAttributes6? TechnicalAttributes { get; init; } 
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}

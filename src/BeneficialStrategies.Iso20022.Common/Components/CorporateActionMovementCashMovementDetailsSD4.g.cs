﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionMovementCashMovementDetailsSD4.  ISO2002 ID# _Wdr4kZCNEeaSk9d1hvTrHg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action movement details.
/// </summary>
public partial record CorporateActionMovementCashMovementDetailsSD4
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    public required IsoMax350Text PlaceAndName { get; init; } 
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Specifies the type of payout associated with the event (for example: principal, long term capital gain).
    /// </summary>
    public required DTCCPayoutType5Code PayoutType { get; init; } 
    /// <summary>
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    /// <summary>
    /// Transaction reason.
    /// </summary>
    public DTCAdjustmentPaymentType2Code? ReasonCode { get; init; } 
    /// <summary>
    /// Transaction sub reason.
    /// </summary>
    public DTCAdjustmentPaymentSubReason1Code? SubReasonCode { get; init; } 
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    /// <summary>
    /// Date/Time on which the posting / draft of cash is scheduled to take place for a transaction.
    /// </summary>
    public IDateFormat28Choice? EarliestPaymentDate { get; init; } 
    /// <summary>
    /// Unique DTCC legacy reference used for matching and reconciling legacy CCF records. The element will be populated to all levels of the message (Event Details, Options, Movements) where applicable to indicate how values are sourced from CCF legacy files. For example: event has 2 related Activity Types 74, and 54. If event details and cash option are sourced from the Activity Type 74, then Activity Type 74 will be in RDP Reference Number in event details, and also on the cash option. The activity type 54 will be "on" the security option. Also, usage rules will specify the different layouts of the RDP Reference Number based on DTCC event group (reorganization, distribution, or redemption).
    /// </summary>
    public IsoExact32AlphaNumericText? RDPReferenceNumber { get; init; } 
    /// <summary>
    /// Set of the DTC legacy sub reason codes representing tax rate. Used with reason codes ‘TJXD’ ‘TJXF’ ‘TJXI’ ‘TJXL’ ‘TJXR’ ‘TJXT’ ‘TJXU’ to identify the correct tax rate.
    /// </summary>
    public IsoPercentageRate? TaxAdjustmentRate { get; init; } 
    
    #nullable disable
}

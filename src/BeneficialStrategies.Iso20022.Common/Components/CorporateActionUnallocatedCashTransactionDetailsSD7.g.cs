﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionUnallocatedCashTransactionDetailsSD7.  ISO2002 ID# _B9NP4Q-tEeuE0Pnt-OcNOA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of unallocated cash transactions.
/// </summary>
public partial record CorporateActionUnallocatedCashTransactionDetailsSD7
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Number identifying the available corporate action option.
    /// </summary>
    public IsoExact3NumericText? OptionNumber { get; init; } 
    /// <summary>
    /// Corporate action options available to the account owner.
    /// </summary>
    public CorporateActionOption11Code? OptionType { get; init; } 
    /// <summary>
    /// Transaction reason.
    /// </summary>
    public DTCAdjustmentPaymentType5Code? ReasonCode { get; init; } 
    /// <summary>
    /// Resulting cash amount concerned in this transaction.
    /// </summary>
    public IsoRestrictedFINActiveCurrencyAndAmount? TransactionAmount { get; init; } 
    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    public DTCUnallocatedAdjustmentReason4Code? UnallocatedReasonCode { get; init; } 
    /// <summary>
    /// Transaction contra participant identification when shares are distributed/delivered to/from another participant.
    /// </summary>
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    public DateFormat48Choice_? EarliestPaymentDate { get; init; } 
    
    #nullable disable
}

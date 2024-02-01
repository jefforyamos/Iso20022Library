﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionUnallocatedSecuritiesTransactionDetailsSD2.  ISO2002 ID# _Z6ragWiLEeOdXoiw6mfXMw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Breakdown of unallocated securities transactions.
/// </summary>
public partial record CorporateActionUnallocatedSecuritiesTransactionDetailsSD2
{
    #nullable enable
    
    /// <summary>
    /// Indicates whether the value is a debit or a credit.
    /// </summary>
    public required CreditDebitCode CreditDebitIndicator { get; init; } 
    /// <summary>
    /// Transaction reason.
    /// </summary>
    public DTCAdjustmentPaymentType1Code? ReasonCode { get; init; } 
    /// <summary>
    /// Resulting quantity of securities concerned in this transaction.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    /// <summary>
    /// Reason for the unallocation.
    /// </summary>
    public DTCUnallocatedAdjustmentReason1Code? UnallocatedReasonCode { get; init; } 
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    /// <summary>
    /// Date/time at which the movement was due to take place (cash and/or securities).
    /// </summary>
    public DateFormat28Choice_? EarliestPaymentDate { get; init; } 
    
    #nullable disable
}

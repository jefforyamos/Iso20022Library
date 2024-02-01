﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionConfirmationSecuritiesMovementDetailsSD1.  ISO2002 ID# _1YSJQDL3EeKU9IrkkToqcw_-1620922820.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding corporate action confirmation securities movement details.
/// </summary>
public partial record CorporateActionConfirmationSecuritiesMovementDetailsSD1
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
    /// Resulting quantity of securities concerned in this transaction.
    /// </summary>
    public FinancialInstrumentQuantity15Choice_? TransactionQuantity { get; init; } 
    /// <summary>
    /// Transaction reason.
    /// </summary>
    public DTCAdjustmentPaymentType1Code? ReasonCode { get; init; } 
    /// <summary>
    /// Transaction contra participant identification when shares are distributed / delivered to / from another participant.
    /// </summary>
    public IsoMax8Text? ContraParticipantNumber { get; init; } 
    /// <summary>
    /// Date/Time on which the posting /draft of the securities took place.
    /// </summary>
    public DateFormat22Choice_? PostingDate { get; init; } 
    
    #nullable disable
}

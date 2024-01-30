﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstrument8.  ISO2002 ID# _SB0r1Np-Ed-ak6NoX_4Aeg_-865361430.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument that has or represents monetary value and is used to process a payment instruction.
/// </summary>
public partial record PaymentInstrument8
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    /// <summary>
    /// Cash account to debit for the payment of a subscription or of a savings plan to an investment fund.
    /// </summary>
    // public IReadOnlyCollection<CashAccount4> CashAccountDetails { get; init; }
    /// <summary>
    /// Settlement instructions for a payment by card.
    /// </summary>
    public required PaymentCard2 PaymentCardDetails { get; init; } 
    /// <summary>
    /// Settlement instructions for a payment by direct debit.
    /// </summary>
    public required DirectDebitMandate4 DirectDebitDetails { get; init; } 
    /// <summary>
    /// Indicates whether the payment is done via cheque.
    /// </summary>
    public required IsoYesNoIndicator Cheque { get; init; } 
    /// <summary>
    /// Indicates whether the payment is done via draft.
    /// </summary>
    public required IsoYesNoIndicator BankersDraft { get; init; } 
    
    #nullable disable
}

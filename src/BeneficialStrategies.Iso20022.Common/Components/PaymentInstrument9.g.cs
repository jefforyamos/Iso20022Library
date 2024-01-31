﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentInstrument9.  ISO2002 ID# _SBq61dp-Ed-ak6NoX_4Aeg_473679007.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Instrument that has or represents monetary value and is used to process a payment instruction.
/// </summary>
public partial record PaymentInstrument9
{
    #nullable enable
    
    /// <summary>
    /// Currency associated with the payment instrument.
    /// </summary>
    public required ActiveCurrencyCode SettlementCurrency { get; init; } 
    /// <summary>
    /// Cash account to credit for the payment of the dividends or of the redeemed investments funds.
    /// </summary>
    public IReadOnlyCollection<CashAccount4> CashAccountDetails { get; init; } = [];
    /// <summary>
    /// Settlement instructions for a payment by cheque.
    /// </summary>
    public required Cheque4 ChequeDetails { get; init; } 
    /// <summary>
    /// Settlement instructions for a payment by draft.
    /// </summary>
    public required Cheque4 BankersDraftDetails { get; init; } 
    
    #nullable disable
}

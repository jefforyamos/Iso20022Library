﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction6.  ISO2002 ID# _9qsqQYqvEeSIDtZ76p6McQ.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Inquiry information for the transaction.
/// </summary>
public partial record ATMTransaction6
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    public CardAccount3? AccountData { get; init; } 
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    /// <summary>
    /// Amount to be authorised by the issuer.
    /// </summary>
    public AmountAndCurrency1? TotalRequestedAmount { get; init; } 
    /// <summary>
    /// Amounts of the withdrawal transaction.
    /// </summary>
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    #nullable disable
}

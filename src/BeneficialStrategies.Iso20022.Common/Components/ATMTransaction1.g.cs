﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction1.  ISO2002 ID# _EW968IohEeSirOZJBRz_nA.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal transaction for which an authorisation is requested.
/// </summary>
public partial record ATMTransaction1
{
    #nullable enable
    
    /// <summary>
    /// True if cash has to be dispensed by the ATM for the transaction.
    /// </summary>
    public IsoTrueFalseIndicator? CashDispensed { get; init; } 
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
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
    /// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
    /// </summary>
    public CurrencyConversion4? CurrencyConversion { get; init; } 
    /// <summary>
    /// Media mix algorithm, the identification of the algorithm is an agreement between the ATM and the ATM manager.
    /// </summary>
    public IsoMax35Text? SelectedMixType { get; init; } 
    /// <summary>
    /// Media mix selected.
    /// </summary>
    public ATMMediaMix1? SelectedMix { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// True if a receipt has be requested by the customer.
    /// </summary>
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction2.  ISO2002 ID# _xrLCMYp4EeS3NqNpgnMh2w.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Response to the withdrawal transaction request.
/// </summary>
public partial record ATMTransaction2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// True if a withdrawal completion advice has to be sent after the end of the transaction.
    /// </summary>
    public IsoTrueFalseIndicator? CompletionRequired { get; init; } 
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    public CardAccount4? AccountData { get; init; } 
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    /// <summary>
    /// Total authorised amount.
    /// </summary>
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; } 
    /// <summary>
    /// Total requested amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    /// <summary>
    /// Detail of the requested amounts for the withdrawal transaction.
    /// </summary>
    public DetailedAmount12? DetailedRequestedAmount { get; init; } 
    /// <summary>
    /// Currency conversion accepted by the customer, either to convert the amount to dispense in the base currency of the ATM, or to convert the total requested amount in the currency of the customer (so called dynamic currency conversion).
    /// </summary>
    public CurrencyConversion4? CurrencyConversion { get; init; } 
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    public DetailedAmount13? AdditionalCharge { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    public ATMTransactionAmounts2? Limits { get; init; } 
    /// <summary>
    /// Media mix algorithm requested by the ATM Host, the identification of the algorithm is an agreement between the ATM and the ATM manager.
    /// </summary>
    public IsoMax35Text? MixType { get; init; } 
    /// <summary>
    /// Media mix selected requested by the ATM Host.
    /// </summary>
    public ATMMediaMix1? Mix { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    public required AuthorisationResult9 AuthorisationResult { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    public ATMCommand1? Command { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

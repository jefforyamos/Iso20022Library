﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction17.  ISO2002 ID# _9LnHMa4KEeWZgJQOa6iKCQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Withdrawal transaction for which the completion is sent.
/// </summary>
public partial record ATMTransaction17
{
    #nullable enable
    
    /// <summary>
    /// Identification of the transaction assigned by the ATM.
    /// </summary>
    public required TransactionIdentifier1 TransactionIdentification { get; init; } 
    /// <summary>
    /// Outcome of the financial transaction for the customer.
    /// </summary>
    public required ATMTransactionStatus1Code TransactionStatus { get; init; } 
    /// <summary>
    /// Multi bundle dispense.
    /// </summary>
    public IsoTrueFalseIndicator? MultiBundle { get; init; } 
    /// <summary>
    /// Amount per bundle in the currency of the total presented amount, in the order of the presentation.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? BundlePresentedAmount { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Status of the amount presented to the customer in the last bundle.
    /// </summary>
    public required ATMTransactionStatus2Code PresentedAmountStatus { get; init; } 
    /// <summary>
    /// Incident occurring during the processing of the transaction.
    /// </summary>
    public FailureReason7Code? Incident { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Explanation of the incident.
    /// </summary>
    public IsoMax70Text? IncidentDetail { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Identification of the reconciliation period assigned by the ATM.
    /// </summary>
    public IsoMax35Text? ReconciliationIdentification { get; init; } 
    /// <summary>
    /// Unprotected account information.
    /// </summary>
    public CardAccount11? AccountData { get; init; } 
    /// <summary>
    /// Encryption of account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountData { get; init; } 
    /// <summary>
    /// Total amount presented to the customer.
    /// </summary>
    public required AmountAndCurrency1 TotalPresentedAmount { get; init; } 
    /// <summary>
    /// Total authorised amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalAuthorisedAmount { get; init; } 
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
    public CurrencyConversion9? CurrencyConversionResult { get; init; } 
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    public DetailedAmount13? AdditionalCharge { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    /// <summary>
    /// True if a receipt has been printed and presented to the customer.
    /// </summary>
    public IsoTrueFalseIndicator? ReceiptPrinted { get; init; } 
    /// <summary>
    /// Explicit consent expressed by a customer on a card-related service proposed by an acquirer or an issuer or any agent acting on behalf of one of them.
    /// </summary>
    public IsoTrueFalseIndicator? CustomerConsent { get; init; } 
    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    public ATMTransactionAmounts6? Limits { get; init; } 
    /// <summary>
    /// Outcome of the withdrawal authorisation.
    /// </summary>
    public AuthorisationResult13? AuthorisationResult { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    /// <summary>
    /// Current totals of the ATM.
    /// </summary>
    public ATMTotals1? ATMTotals { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information on the cassettes of the ATM.
    /// </summary>
    public ATMCassette2? Cassette { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

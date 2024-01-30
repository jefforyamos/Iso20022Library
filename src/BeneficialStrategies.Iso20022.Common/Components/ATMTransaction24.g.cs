﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction24.  ISO2002 ID# _Ez0uka4zEeWpsoxRhdX-8A.
//

using BeneficialStrategies.Iso20022.Choices;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer information for the transaction.
/// </summary>
public partial record ATMTransaction24
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
    /// Description of the transfer for the creditor.
    /// </summary>
    public IsoMax35Text? CreditorLabel { get; init; } 
    /// <summary>
    /// Description of the transfer for the debtor.
    /// </summary>
    public IsoMax35Text? DebtorLabel { get; init; } 
    /// <summary>
    /// Identifier of the approved transfer transaction for the bank.
    /// </summary>
    public IsoMax70Text? TransferIdentifier { get; init; } 
    /// <summary>
    /// Reference of the payment.
    /// </summary>
    public IsoMax35Text? PaymentReference { get; init; } 
    /// <summary>
    /// Result of the fund transfer request.
    /// </summary>
    public required ResponseType7 TransactionResponse { get; init; } 
    /// <summary>
    /// Sequence of actions to be performed by the ATM to complete the transaction.
    /// </summary>
    public Action7? Action { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information about the source account of the transfer.
    /// </summary>
    public CardAccount13? AccountFrom { get; init; } 
    /// <summary>
    /// Encryption of the source account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountFrom { get; init; } 
    /// <summary>
    /// Information about the destination account of the transfer.
    /// </summary>
    public CardAccount13? AccountTo { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Encryption of the destination account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountTo { get; init; } 
    /// <summary>
    /// Total authorised amount.
    /// </summary>
    public required AmountAndCurrency1 TotalAuthorisedAmount { get; init; } 
    /// <summary>
    /// Total requested amount.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    /// <summary>
    /// Details of the transfer transaction amounts.
    /// </summary>
    public DetailedAmount17? DetailedRequestedAmount { get; init; } 
    /// <summary>
    /// Additional charge (for instance tax or fee).
    /// </summary>
    public DetailedAmount18? AdditionalCharge { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Limit of amounts for the customer.
    /// </summary>
    public ATMTransactionAmounts6? Limits { get; init; } 
    /// <summary>
    /// Requested date of the execution of the transfer.
    /// </summary>
    public IsoISODate? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Proposed date of the execution of the transfer.
    /// </summary>
    public IsoISODate? ProposedExecutionDate { get; init; } 
    /// <summary>
    /// Identifies the instant transfer program.
    /// </summary>
    public IsoMax35Text? InstantTransferProgram { get; init; } 
    /// <summary>
    /// Information for reccurring transfer or standing orders.
    /// </summary>
    public RecurringTransaction3? RecurringTransfer { get; init; } 
    /// <summary>
    /// Outcome of the transfer authorisation.
    /// </summary>
    public AuthorisationResult13? AuthorisationResult { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    /// <summary>
    /// Maintenance command to perform on the ATM.
    /// </summary>
    public ATMCommand7? Command { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

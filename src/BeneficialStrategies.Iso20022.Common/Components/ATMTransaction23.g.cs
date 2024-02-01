﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ATMTransaction23.  ISO2002 ID# _t-Wk8a4tEeWLdt0vLARX2Q.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transfer information for the transaction.
/// </summary>
public partial record ATMTransaction23
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
    /// Reference of the payment.
    /// </summary>
    public IsoMax35Text? PaymentReference { get; init; } 
    /// <summary>
    /// Information about the source account of the transfer.
    /// </summary>
    public CardAccount7? AccountFrom { get; init; } 
    /// <summary>
    /// Encryption of the source account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountFrom { get; init; } 
    /// <summary>
    /// Information about the destination account of the transfer.
    /// </summary>
    public CardAccount7[] AccountTo { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Encryption of the destination account information.
    /// </summary>
    public ContentInformationType10? ProtectedAccountTo { get; init; } 
    /// <summary>
    /// Amount of the transaction to be authorised.
    /// </summary>
    public IsoImpliedCurrencyAndAmount? TotalRequestedAmount { get; init; } 
    /// <summary>
    /// Details of the transfer transaction amounts.
    /// </summary>
    public DetailedAmount17? DetailedRequestedAmount { get; init; } 
    /// <summary>
    /// Requested date of the execution of the transfer.
    /// </summary>
    public IsoISODate? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Identifies the instant transfer program.
    /// </summary>
    public IsoMax35Text? InstantTransferProgram { get; init; } 
    /// <summary>
    /// Information for reccurring transfer or standing orders.
    /// </summary>
    public RecurringTransaction3? RecurringTransfer { get; init; } 
    /// <summary>
    /// True if the customer has requested a receipt.
    /// </summary>
    public IsoTrueFalseIndicator? RequestedReceipt { get; init; } 
    /// <summary>
    /// Sequence of one or more TLV data elements from the ATM application, in accordance with ISO 7816-6, not in a specific order. Present if the transaction is performed with an EMV chip card application.
    /// </summary>
    public IsoMax10000Binary? ICCRelatedData { get; init; } 
    
    #nullable disable
}

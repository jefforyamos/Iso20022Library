﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalPaymentInformation7.  ISO2002 ID# _Ka3F-ZRpEeazAtAtDSg0Nw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information on the original payment transaction, to which the remittance message applies.
/// </summary>
public partial record OriginalPaymentInformation7
{
    #nullable enable
    
    /// <summary>
    /// Identifies the underlying transaction.
    /// </summary>
    public required TransactionReferences4 References { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    public IAmountType3Choice? Amount { get; init; } 
    /// <summary>
    /// Provides details of the currency exchange rate and contract.
    /// </summary>
    public ExchangeRate1? ExchangeRateInformation { get; init; } 
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    public IDateAndDateTimeChoice? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    public IsoISODate? RequestedCollectionDate { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification43? Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public CashAccount24? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public PartyIdentification43? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount24? CreditorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? CreditorAgent { get; init; } 
    
    #nullable disable
}

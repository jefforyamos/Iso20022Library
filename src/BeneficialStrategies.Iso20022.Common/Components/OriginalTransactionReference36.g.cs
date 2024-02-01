﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for OriginalTransactionReference36.  ISO2002 ID# _bxDV8dcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies key elements as defined in the original transaction.
/// </summary>
public partial record OriginalTransactionReference36
{
    #nullable enable
    
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? InterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    public AmountType4Choice_? Amount { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public IsoISODate? InterbankSettlementDate { get; init; } 
    /// <summary>
    /// Date and time at which the creditor requests that the amount of money is to be collected from the debtor.
    /// </summary>
    public IsoISODate? RequestedCollectionDate { get; init; } 
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    public DateAndDateTime2Choice_? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Credit party that signs the mandate.
    /// </summary>
    public PartyIdentification135? CreditorSchemeIdentification { get; init; } 
    /// <summary>
    /// Specifies the details on how the settlement of the original transaction(s) between the instructing agent and the instructed agent was completed.
    /// </summary>
    public SettlementInstruction11? SettlementInformation { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation27? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Specifies the means of payment that will be used to move the amount of money.
    /// </summary>
    public PaymentMethod4Code? PaymentMethod { get; init; } 
    /// <summary>
    /// Provides further details of the mandate signed between the creditor and the debtor.
    /// </summary>
    public MandateRelatedData2Choice_? MandateRelatedInformation { get; init; } 
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    public RemittanceInformation21? RemittanceInformation { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public Party40Choice_? UltimateDebtor { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public Party40Choice_? Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public CashAccount40? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    public CashAccount40? CreditorAgentAccount { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public Party40Choice_? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount40? CreditorAccount { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public Party40Choice_? UltimateCreditor { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction.
    /// Usage: 
    /// Purpose is used by the end customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public Purpose2Choice_? Purpose { get; init; } 
    /// <summary>
    /// Provides information on the underlying customer credit transfer for which cover is provided.
    /// </summary>
    public CreditTransferTransaction52? UnderlyingCustomerCreditTransfer { get; init; } 
    
    #nullable disable
}

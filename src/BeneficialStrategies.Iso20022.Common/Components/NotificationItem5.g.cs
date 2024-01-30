﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NotificationItem5.  ISO2002 ID# _a-naox77EeSxevWRRWxNAg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further means of referencing a payment transaction.
/// </summary>
public partial record NotificationItem5
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by the account owner, to unambiguously identify the expected credit entry.
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the debtor, to unambiguously identify the underlying transaction to the creditor. |Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction.
    /// </summary>
    public IsoMax35Text? EndToEndIdentification { get; init; } 
    /// <summary>
    /// Identifies the account to be credited with the incoming amount of money.
    /// </summary>
    public CashAccount24? Account { get; init; } 
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public IParty12Choice? AccountOwner { get; init; } 
    /// <summary>
    /// Party that manages the account on behalf of the account owner, that is manages the registration and booking of entries on the account, calculates balances on the account and provides information about the account.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? AccountServicer { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public CashAccount24? RelatedAccount { get; init; } 
    /// <summary>
    /// Amount of money expected to be credited to the account.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Value date on which the account is expected to be credited.
    /// </summary>
    public IsoISODate? ExpectedValueDate { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public IParty12Choice? Debtor { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? DebtorAgent { get; init; } 
    /// <summary>
    /// Agent between the debtor agent and the account servicer.|Usage: This is the agent from which the account servicer will get the amount of money. If there is more than one intermediary agent, then IntermediaryAgent identifies the agent closest to the account servicer.|IntermediaryAgent must only be included when different from the debtor agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    public IPurpose2Choice? Purpose { get; init; } 
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    public RemittanceLocation4? RelatedRemittanceInformation { get; init; } 
    /// <summary>
    /// Structured information that enables the reconciliation of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    public RemittanceInformation10? RemittanceInformation { get; init; } 
    
    #nullable disable
}

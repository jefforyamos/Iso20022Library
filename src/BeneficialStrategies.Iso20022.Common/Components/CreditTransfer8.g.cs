﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditTransfer8.  ISO2002 ID# _xp4-czbsEead9bDRE_1DAQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
/// </summary>
public partial record CreditTransfer8
{
    #nullable enable
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    public IsoMax35Text? Reference { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
    /// </summary>
    public PartyIdentification113? Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public AccountIdentificationAndName5? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public FinancialInstitutionIdentification10? DebtorAgent { get; init; } 
    /// <summary>
    /// Identifies the account of the debtor's agent.
    /// </summary>
    public AccountIdentificationAndName5? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    public FinancialInstitutionIdentification10? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    public AccountIdentificationAndName5? IntermediaryAgent1Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    public FinancialInstitutionIdentification10? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    public AccountIdentificationAndName5? IntermediaryAgent2Account { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public required FinancialInstitutionIdentification10 CreditorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    public AccountIdentificationAndName5? CreditorAgentAccount { get; init; } 
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    public PartyIdentification113? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public required AccountIdentificationAndName5 CreditorAccount { get; init; } 
    
    #nullable disable
}

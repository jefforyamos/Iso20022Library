﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CreditTransferDetails.  ISO2002 ID# _iPPvEVNaEeijdq8ilaxyOA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument23Choice;

/// <summary>
/// Payment instrument between a debtor and a creditor that flows through one or more financial institutions or systems.
/// </summary>
public partial record CreditTransferDetails : IPaymentInstrument23Choice
{
    #nullable enable
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
    /// </summary>
    public PartyIdentification132? Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public AccountIdentificationAndName6? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing the account for the debtor.
    /// </summary>
    public FinancialInstitutionIdentification16? DebtorAgent { get; init; } 
    /// <summary>
    /// Identifies the account of the debtor's agent.
    /// </summary>
    public AccountIdentificationAndName6? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    public FinancialInstitutionIdentification16? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    public AccountIdentificationAndName6? IntermediaryAgent1Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    public FinancialInstitutionIdentification16? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    public AccountIdentificationAndName6? IntermediaryAgent2Account { get; init; } 
    /// <summary>
    /// Financial institution servicing the account for the creditor.
    /// </summary>
    public required FinancialInstitutionIdentification16 CreditorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    public AccountIdentificationAndName6? CreditorAgentAccount { get; init; } 
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    public PartyIdentification132? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public required AccountIdentificationAndName6 CreditorAccount { get; init; } 
    #nullable disable
}

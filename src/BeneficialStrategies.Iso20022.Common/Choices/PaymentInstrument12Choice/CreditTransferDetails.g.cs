﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CreditTransferDetails.  ISO2002 ID# _SBX_6tp-Ed-ak6NoX_4Aeg_1545983660.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument12Choice;

/// <summary>
/// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
/// </summary>
public partial record CreditTransferDetails : PaymentInstrument12Choice_
{
    #nullable enable
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    public IsoMax35Text? Reference { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor. In the context of the payment model, the debtor is also the debit account owner.
    /// </summary>
    public PartyIdentification2Choice_? Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public AccountIdentificationAndName3? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public FinancialInstitutionIdentification3Choice_? DebtorAgent { get; init; } 
    /// <summary>
    /// Identifies the account of the debtor's agent.
    /// </summary>
    public AccountIdentificationAndName3? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    public FinancialInstitutionIdentification3Choice_? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    public AccountIdentificationAndName3? IntermediaryAgent1Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.
    /// </summary>
    public FinancialInstitutionIdentification3Choice_? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    public AccountIdentificationAndName3? IntermediaryAgent2Account { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public required FinancialInstitutionIdentification3Choice_ CreditorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    public AccountIdentificationAndName3? CreditorAgentAccount { get; init; } 
    /// <summary>
    /// Party that receives an amount of money from the debtor. In the context of the payment model, the creditor is also the credit account owner.
    /// </summary>
    public PartyIdentification2Choice_? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public required AccountIdentificationAndName3 CreditorAccount { get; init; } 
    #nullable disable
}

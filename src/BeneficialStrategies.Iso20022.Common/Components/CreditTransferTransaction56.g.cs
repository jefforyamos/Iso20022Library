﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditTransferTransaction56.  ISO2002 ID# _g4Cd4dcZEeqRFcf2R4bPBw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provide further details specific to the individual transaction(s) included in the message.
/// </summary>
public partial record CreditTransferTransaction56
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    public required PaymentIdentification13 PaymentIdentification { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation28? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    public required IsoActiveCurrencyAndAmount InterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public IsoISODate? InterbankSettlementDate { get; init; } 
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// </summary>
    public Priority3Code? SettlementPriority { get; init; } 
    /// <summary>
    /// Provides information on the occurred settlement time(s) of the payment transaction.
    /// </summary>
    public SettlementDateTimeIndication1? SettlementTimeIndication { get; init; } 
    /// <summary>
    /// Provides information on the requested settlement time(s) of the payment instruction.
    /// </summary>
    public SettlementTimeRequest2? SettlementTimeRequest { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the instructing agent. 
    /// Usage: If more than one previous instructing agent is present, then PreviousInstructingAgent1 identifies the agent between the DebtorAgent and the PreviousInstructingAgent2.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? PreviousInstructingAgent1Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the instructing agent. 
    /// Usage: If more than two previous instructing agent are present, then PreviousInstructingAgent2 identifies the agent between the PreviousInstructingAgent1 and the PreviousInstructingAgent3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? PreviousInstructingAgent2Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the instructing agent. 
    /// Usage: If PreviousInstructingAgent3 is present, then PreviousInstructingAgent3 identifies the agent between the PreviousInstructingAgent2 and the InstructingAgent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? PreviousInstructingAgent3Account { get; init; } 
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? InstructingAgent { get; init; } 
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 1 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? IntermediaryAgent1Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? IntermediaryAgent2Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount40? IntermediaryAgent3Account { get; init; } 
    /// <summary>
    /// Ultimate financial institution that owes an amount of money to the (ultimate) institutional creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? UltimateDebtor { get; init; } 
    /// <summary>
    /// Financial institution that owes an amount of money to the (ultimate) financial institutional creditor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 Debtor { get; init; } 
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
    /// Financial institution that receives an amount of money from the financial institutional debtor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount40? CreditorAccount { get; init; } 
    /// <summary>
    /// Ultimate financial institution to which an amount of money is due.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? UltimateCreditor { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    public InstructionForCreditorAgent3? InstructionForCreditorAgent { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    public InstructionForNextAgent1? InstructionForNextAgent { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public IPurpose2Choice? Purpose { get; init; } 
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    public RemittanceInformation2? RemittanceInformation { get; init; } 
    /// <summary>
    /// Provides information on the underlying customer credit transfer for which cover is provided.
    /// </summary>
    public CreditTransferTransaction52? UnderlyingCustomerCreditTransfer { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

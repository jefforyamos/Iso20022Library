﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CreditTransferTransaction39.  ISO2002 ID# _447bMXL-EeidQ_AAdEzxQA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details specific to the individual transaction(s) included in the message.
/// </summary>
public partial record CreditTransferTransaction39
{
    #nullable enable
    
    /// <summary>
    /// Set of elements used to reference a payment instruction.
    /// </summary>
    public required PaymentIdentification7 PaymentIdentification { get; init; } 
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
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
    /// <summary>
    /// Date used for the correction of the value date of a cash pool movement that has been posted with a different value date.
    /// </summary>
    public IsoISODate? PoolingAdjustmentDate { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? InstructedAmount { get; init; } 
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public required ChargeBearerType1Code ChargeBearer { get; init; } 
    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the payment transaction.
    /// </summary>
    public Charges7? ChargesInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent1 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount38? PreviousInstructingAgent1Account { get; init; } 
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent2 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount38? PreviousInstructingAgent2Account { get; init; } 
    /// <summary>
    /// Agent immediately prior to the instructing agent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? PreviousInstructingAgent3 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the previous instructing agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount38? PreviousInstructingAgent3Account { get; init; } 
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
    public CashAccount38? IntermediaryAgent1Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 2 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount38? IntermediaryAgent2Account { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? IntermediaryAgent3 { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the intermediary agent 3 at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount38? IntermediaryAgent3Account { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification135? UltimateDebtor { get; init; } 
    /// <summary>
    /// Party that initiates the payment.|Usage: This can be either the debtor or a party that initiates the credit transfer on behalf of the debtor.
    /// </summary>
    public PartyIdentification135? InitiatingParty { get; init; } 
    /// <summary>
    /// Party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public required PartyIdentification135 Debtor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor to which a debit entry will be made as a result of the transaction.
    /// </summary>
    public CashAccount38? DebtorAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 DebtorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the debtor agent at its servicing agent in the payment chain.
    /// </summary>
    public CashAccount38? DebtorAgentAccount { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 CreditorAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor agent at its servicing agent to which a credit entry will be made as a result of the payment transaction.
    /// </summary>
    public CashAccount38? CreditorAgentAccount { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public required PartyIdentification135 Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount38? CreditorAccount { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public PartyIdentification135? UltimateCreditor { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    public InstructionForCreditorAgent1? InstructionForCreditorAgent { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Further information related to the processing of the payment instruction that may need to be acted upon by the next agent. ||Usage: The next agent may not be the creditor agent.|The instruction can relate to a level of service, can be an instruction that has to be executed by the agent, or can be information required by the next agent.
    /// </summary>
    public InstructionForNextAgent1? InstructionForNextAgent { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Underlying reason for the payment transaction.|Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public IPurpose2Choice? Purpose { get; init; } 
    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    // public IReadOnlyCollection<RegulatoryReporting3> RegulatoryReporting { get; init; }
    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    public TaxInformation8? Tax { get; init; } 
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    // public IReadOnlyCollection<RemittanceLocation7> RelatedRemittanceInformation { get; init; }
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    public RemittanceInformation16? RemittanceInformation { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Credit.  ISO2002 ID# _h2zp0A2uEeSNWNtJlXOAhg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SettlementMethod1Choice;

/// <summary>
/// Specifies details of the payment to be made by the old account servicer to the new account servicer in case of a positive closing balance.
/// </summary>
public partial record Credit : ISettlementMethod1Choice
{
    #nullable enable
    /// <summary>
    /// Set of elements used to reference a payment instruction. 
    /// </summary>
    public required PaymentIdentification1 PaymentIdentification { get; init; } 
    /// <summary>
    /// Set of elements used to further specify the type of transaction.
    /// </summary>
    public PaymentTypeInformation19? PaymentTypeInformation { get; init; } 
    /// <summary>
    /// Specifies the rate of tax levied.
    /// </summary>
    public TaxRateMarker1Code? TaxRateMarker { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    public required IsoActiveCurrencyAndAmount Amount { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Set of elements needed to issue a cheque.
    /// </summary>
    public Cheque7? ChequeInstruction { get; init; } 
    /// <summary>
    /// The schedule for a credit payment arrangement. 
    /// </summary>
    public Frequency1? Frequency { get; init; } 
    /// <summary>
    /// Provides further information about the status of transferred scheduled payment(s).
    /// </summary>
    public TransferInstruction1? TransferInstruction { get; init; } 
    /// <summary>
    /// Ultimate party that owes an amount of money to the (ultimate) creditor.
    /// </summary>
    public PartyIdentification125? UltimateDebtor { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than one intermediary agent is present, then IntermediaryAgent1 identifies the agent between the DebtorAgent and the IntermediaryAgent2.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent1 { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If more than two intermediary agents are present, then IntermediaryAgent2 identifies the agent between the IntermediaryAgent1 and the IntermediaryAgent3.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent2 { get; init; } 
    /// <summary>
    /// Agent between the debtor's agent and the creditor's agent.||Usage: If IntermediaryAgent3 is present, then it identifies the agent between the IntermediaryAgent 2 and the CreditorAgent.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? IntermediaryAgent3 { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification5 CreditorAgent { get; init; } 
    /// <summary>
    /// Party to which an amount of money is due.
    /// </summary>
    public PartyIdentification125? Creditor { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the creditor to which a credit entry will be posted as a result of the payment transaction.
    /// </summary>
    public CashAccount24? CreditorAccount { get; init; } 
    /// <summary>
    /// Ultimate party to which an amount of money is due.
    /// </summary>
    public PartyIdentification125? UltimateCreditor { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction, provided by the initiating party, and intended for the creditor agent.
    /// </summary>
    public InstructionForCreditorAgent1? InstructionForCreditorAgent { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Underlying reason for the payment transaction.
    /// Usage: Purpose is used by the end-customers, that is initiating party, (ultimate) debtor, (ultimate) creditor to provide information concerning the nature of the payment. Purpose is a content element, which is not used for processing by any of the agents involved in the payment chain.
    /// </summary>
    public IPurpose2Choice? Purpose { get; init; } 
    /// <summary>
    /// Information needed due to regulatory and statutory requirements.
    /// </summary>
    // public IReadOnlyCollection<RegulatoryReporting3> RegulatoryReporting { get; init; }
    /// <summary>
    /// Provides details on the tax.
    /// </summary>
    public TaxInformation6? Tax { get; init; } 
    /// <summary>
    /// Provides information related to the handling of the remittance information by any of the agents in the transaction processing chain.
    /// </summary>
    // public IReadOnlyCollection<RemittanceLocation2> RelatedRemittanceInformation { get; init; }
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts' receivable system.
    /// </summary>
    public RemittanceInformation14? RemittanceInformation { get; init; } 
    #nullable disable
}

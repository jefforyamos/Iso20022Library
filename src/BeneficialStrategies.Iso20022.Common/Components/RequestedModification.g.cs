﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RequestedModification.  ISO2002 ID# _PgTKQdp-Ed-ak6NoX_4Aeg_-1564522942.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the requested modifications.
/// </summary>
public partial record RequestedModification
{
    #nullable enable
    
    /// <summary>
    /// Reference relating to a linked payment instruction or agreement which is meaningful to both parties (eg, the content of field 21 in a cover instruction).
    /// </summary>
    public IsoMax35Text? RelatedReference { get; init; } 
    /// <summary>
    /// SWIFT defined service level applies to the payment instruction.
    /// </summary>
    public SWIFTServiceLevel2Code? BankOperationCode { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.
    /// </summary>
    public Instruction1Code? InstructionCode { get; init; } 
    /// <summary>
    /// Date and time the debtor requests the clearing agent to process the payment instruction.
    /// </summary>
    public IsoISODate? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    public IsoCurrencyAndAmount? InterbankSettledAmount { get; init; } 
    /// <summary>
    /// Debtor or Ordering customer of the payment instruction.
    /// </summary>
    public PartyIdentification1? Debtor { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccount3? DebtorAccount { get; init; } 
    /// <summary>
    /// Party that executes a cash transfer received via a clearing agent or on request of an agreement party.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification? IntermediarySettlementAgent { get; init; } 
    /// <summary>
    /// Party that executes a cash transfer received via a clearing agent or on request of an agreement party.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification? LastSettlementAgent { get; init; } 
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents, or the channel through which the payment instruction is to be processed. This payment scheme can point to a specific rulebook governing the rules of clearing and settlement between two parties.
    /// </summary>
    public IPaymentSchemeChoice? PaymentScheme { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccount3? BeneficiaryInstitutionAccount { get; init; } 
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    public PartyIdentification1? Creditor { get; init; } 
    /// <summary>
    /// Account to or from which a cash entry is made.
    /// </summary>
    public CashAccount3? CreditorAccount { get; init; } 
    /// <summary>
    /// Structured information that enables the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, such as commercial invoices in an account receivable system.
    /// </summary>
    public IRemittanceInformation3Choice? RemittanceInformation { get; init; } 
    /// <summary>
    /// Underlying reason for the payment transaction.
    /// </summary>
    public IPurposeChoice? Purpose { get; init; } 
    /// <summary>
    /// Further information related to the processing of the payment instruction. The instruction can relate to a level of service between the bank and the customer, or give instructions to and for specific parties in the payment chain.
    /// </summary>
    public InstructionForFinalAgent? InstructionForFinalAgent { get; init; } 
    /// <summary>
    /// Party(ies) liable for a charge associated with the transfer of cash.
    /// </summary>
    public ChargeBearer1Code? DetailsOfCharges { get; init; } 
    /// <summary>
    /// Unformatted information from the sender to the receiver.
    /// </summary>
    public IReadOnlyCollection<IsoMax35Text> SenderToReceiverInformation { get; init; } = [];
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransaction87.  ISO2002 ID# _llmuYYmdEeeKR__nUfxjwA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reference and status on the original transactions, included in the original instruction, to which the return message applies.
/// </summary>
public partial record PaymentTransaction87
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the returned transaction.|Usage: The instructing party is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    public IsoMax35Text? ReturnIdentification { get; init; } 
    /// <summary>
    /// Provides information on the original message.
    /// </summary>
    public OriginalGroupInformation29? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original first instructing agent, to unambiguously identify the transaction.
    /// </summary>
    public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by the original clearing system, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalClearingSystemReference { get; init; } 
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent, as provided in the original instruction.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// Usage: the OriginalInterbankSettlementDate is the interbank settlement date of the original instruction return message, and not of the return message.
    /// </summary>
    public IsoISODate? OriginalInterbankSettlementDate { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the instructing agent and the instructed agent in the returned instruction.
    /// </summary>
    public required IsoActiveCurrencyAndAmount ReturnedInterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.||Usage: the InterbankSettlementDate is the interbank settlement date of the return message, and not of the original instruction.
    /// </summary>
    public IsoISODate? InterbankSettlementDate { get; init; } 
    /// <summary>
    /// Indicator of the urgency or order of importance that the instructing party would like the instructed party to apply to the processing of the settlement instruction.
    /// Usage: the SettlementPriority is the settlement priority of the return message, and not of the original instruction.
    /// </summary>
    public Priority3Code? SettlementPriority { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and the creditor, before deduction of charges, in the returned transaction.
    /// Usage: This amount has to be transported unchanged through the transaction chain.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? ReturnedInstructedAmount { get; init; } 
    /// <summary>
    /// Factor used to convert an amount from one currency into another. This reflects the price at which one currency was bought with another currency.
    /// </summary>
    public IsoBaseOneRate? ExchangeRate { get; init; } 
    /// <summary>
    /// Amount of money asked or paid as compensation for the processing of the instruction.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? CompensationAmount { get; init; } 
    /// <summary>
    /// Specifies which party/parties will bear the charges associated with the processing of the payment transaction.||Usage: The ChargeBearer applies to the return message, not to the original instruction.
    /// </summary>
    public ChargeBearerType1Code? ChargeBearer { get; init; } 
    /// <summary>
    /// Provides information on the charges to be paid by the charge bearer(s) related to the processing of the return transaction.
    /// </summary>
    public Charges2? ChargesInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Unique reference, as assigned by the clearing system, to unambiguously identify the return instruction.
    /// </summary>
    public IsoMax35Text? ClearingSystemReference { get; init; } 
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the return message and not the party that sent the original instruction that is being returned.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? InstructingAgent { get; init; } 
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the return message and not the party that received the original instruction that is being returned.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification5? InstructedAgent { get; init; } 
    /// <summary>
    /// Provides all parties (agents and non-agents) involved in a return transaction.
    /// </summary>
    public TransactionParties5? ReturnChain { get; init; } 
    /// <summary>
    /// Provides detailed information on the return reason.
    /// </summary>
    public PaymentReturnReason4? ReturnReasonInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Key elements used to identify the original transaction that is being referred to.
    /// </summary>
    public OriginalTransactionReference27? OriginalTransactionReference { get; init; } 
    /// <summary>
    /// Additional information that cannot be captured in the structured elements and/or any other specific block.
    /// </summary>
    public SupplementaryData1? SupplementaryData { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

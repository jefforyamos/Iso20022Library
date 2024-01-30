﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for ShortBusinessIdentification.  ISO2002 ID# _5uqG9wKxEe2rHs6fbn9-0A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification7Choice;

/// <summary>
/// Business identification of the payment instruction given by the clearing agent.
/// </summary>
public partial record ShortBusinessIdentification : IPaymentIdentification7Choice
{
    #nullable enable
    /// <summary>
    /// Unique identification, as assigned by the first instructing agent, to unambiguously identify the transaction that is passed on, unchanged, throughout the entire interbank chain.|Usage: The transaction identification can be used for reconciliation, tracking or to link tasks relating to the transaction on the interbank level. The instructing agent has to make sure that the transaction identification is unique for a pre-agreed period.|Usage: this is the former PaymentInstructionReference element.
    /// </summary>
    public IsoMax35Text? TransactionIdentification { get; init; } 
    /// <summary>
    /// Universally unique identifier to provide an end-to-end reference of a payment transaction.
    /// </summary>
    public IsoUUIDv4Identifier? UETR { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public required IsoISODate InterbankSettlementDate { get; init; } 
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public required BranchAndFinancialInstitutionIdentification6 InstructingAgent { get; init; } 
    #nullable disable
}

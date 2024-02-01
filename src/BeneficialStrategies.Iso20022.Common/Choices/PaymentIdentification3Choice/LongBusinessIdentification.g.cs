﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LongBusinessIdentification.  ISO2002 ID# _Rbhg0tp-Ed-ak6NoX_4Aeg_-1132471706.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification3Choice;

/// <summary>
/// Business identification of the payment instruction given by the clearing agent.
/// </summary>
public partial record LongBusinessIdentification : PaymentIdentification3Choice_
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identifier for a payment instruction, as assigned by the clearing agent or the initiating party.
    /// </summary>
    public required IsoMax35Text PaymentInstructionReference { get; init; } 
    /// <summary>
    /// Amount of money moved between the instructing agent and the instructed agent.
    /// </summary>
    public required IsoImpliedCurrencyAndAmount InterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public required IsoISODate InterbankValueDate { get; init; } 
    /// <summary>
    /// The message type with which the instruction has been initiated.
    /// </summary>
    public PaymentOrigin1Choice_? PaymentMethod { get; init; } 
    /// <summary>
    /// The identification of the instructing agent that transmitted the payment instruction.
    /// </summary>
    public required IsoBICIdentifier InstructingAgentIdentification { get; init; } 
    /// <summary>
    /// The identification of the instructed agent in the payment instruction.
    /// </summary>
    public required IsoBICIdentifier InstructedAgentIdentification { get; init; } 
    /// <summary>
    /// An optional qualifier providing additional system specific information about the entry.||Usage:
    /// </summary>
    public IsoEntryTypeIdentifier? EntryType { get; init; } 
    /// <summary>
    /// The related reference as stipulated in the payment instruction.
    /// </summary>
    public IsoMax35Text? RelatedReference { get; init; } 
    #nullable disable
}

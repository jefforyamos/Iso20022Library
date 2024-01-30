﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Initiation.  ISO2002 ID# _9GWT4a6UEeexrtTFgmVD3Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CorrectiveTransaction3Choice;

/// <summary>
/// Set of elements used to reference the details of the corrective payment initiation.
/// </summary>
public partial record Initiation : ICorrectiveTransaction3Choice
{
    #nullable enable
    /// <summary>
    /// Set of elements used to provide corrective information for the group header of the message under investigation.
    /// </summary>
    public CorrectiveGroupInformation1? GroupHeader { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by a sending party, to unambiguously identify the payment information group within the message.
    /// </summary>
    public IsoMax35Text? PaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the instruction.||Usage: The instruction identification is a point to point reference that can be used between the instructing party and the instructed party to refer to the individual instruction. It can be included in several messages related to the instruction.
    /// </summary>
    public IsoMax35Text? InstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the initiating party, to unambiguously identify the transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.||Usage: The end-to-end identification can be used for reconciliation or to link tasks relating to the transaction. It can be included in several messages related to the transaction.||Usage: In case there are technical limitations to pass on multiple references, the end-to-end identification must be passed on throughout the entire end-to-end chain.
    /// </summary>
    public IsoMax35Text? EndToEndIdentification { get; init; } 
    /// <summary>
    /// Amount of money to be moved between the debtor and creditor, before deduction of charges, expressed in the currency as ordered by the initiating party.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount InstructedAmount { get; init; } 
    /// <summary>
    /// Date or date time at which the initiating party requests the clearing agent to process the payment. 
    /// Usage: This is the date or date time on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    public IDateAndDateTime2Choice? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date at which the creditor requests the amount of money to be collected from the debtor.
    /// </summary>
    public IsoISODate? RequestedCollectionDate { get; init; } 
    #nullable disable
}

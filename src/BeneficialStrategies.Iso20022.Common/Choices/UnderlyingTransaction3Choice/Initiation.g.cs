﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Initiation.  ISO2002 ID# _X0Xj4WXpEeap-P22vGV91g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction3Choice;

/// <summary>
/// Set of elements used to reference the details of the original payment initiation.
/// </summary>
public partial record Initiation : IUnderlyingTransaction3Choice
{
    #nullable enable
    /// <summary>
    /// Set of elements used to provide information on the original message.
    /// </summary>
    public UnderlyingGroupInformation1? OriginalGroupInformation { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original sending party, to unambiguously identify the original payment information group.
    /// </summary>
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original instructing party for the original instructed party, to unambiguously identify the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Unique identification, as assigned by the original initiating party, to unambiguously identify the original transaction.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the debtor and the creditor, before deduction of charges, expressed in the currency, as ordered by the original initiating party.
    /// </summary>
    public required IsoActiveOrHistoricCurrencyAndAmount OriginalInstructedAmount { get; init; } 
    /// <summary>
    /// Date at which the initiating party requests the clearing agent to process the payment. |Usage: This is the date on which the debtor's account is to be debited. If payment by cheque, the date when the cheque must be generated by the bank.
    /// </summary>
    public IDateAndDateTimeChoice? RequestedExecutionDate { get; init; } 
    /// <summary>
    /// Date at which the creditor requests the amount of money to be collected from the debtor.
    /// </summary>
    public IsoISODate? RequestedCollectionDate { get; init; } 
    #nullable disable
}

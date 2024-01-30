﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransactionInformation33.  ISO2002 ID# _P69tANp-Ed-ak6NoX_4Aeg_-1329990954.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide reference and status information on the original transactions, included in the original instruction, to which the cancellation request message applies.
/// </summary>
public partial record PaymentTransactionInformation33
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier of a cancellation request status, as assigned by the assigner.||Usage: The cancellation status identification can be used for reconciliation or to link tasks relating to the cancellation request.
    /// </summary>
    public IsoMax35Text? CancellationStatusIdentification { get; init; } 
    /// <summary>
    /// Identifies the resolved case.
    /// </summary>
    public Case2? ResolvedCase { get; init; } 
    /// <summary>
    /// Set of elements used to provide information on the original messsage.
    /// </summary>
    public OriginalGroupInformation3? OriginalGroupInformation { get; init; } 
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
    /// Specifies the status of the transaction cancellation request.
    /// </summary>
    public CancellationIndividualStatus1Code? TransactionCancellationStatus { get; init; } 
    /// <summary>
    /// Set of elements used to provide detailed information on the cancellation status reason.
    /// </summary>
    public CancellationStatusReasonInformation1? CancellationStatusReasonInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Reference of a return or a reversal transaction that is initiated to fix the case under investigation as part of the resolution.
    /// </summary>
    public ResolutionInformation1? ResolutionRelatedInformation { get; init; } 
    /// <summary>
    /// Amount of money, as provided in the original transaction, to be moved between the instructing agent and the instructed agent.
    /// </summary>
    public IsoActiveOrHistoricCurrencyAndAmount? OriginalInterbankSettlementAmount { get; init; } 
    /// <summary>
    /// Date, as provided in the original transaction, on which the amount of money ceases to be available to the agent that owes it and when the amount of money becomes available to the agent to which it is due.
    /// </summary>
    public IsoISODate? OriginalInterbankSettlementDate { get; init; } 
    /// <summary>
    /// Party who assigns the case.|Usage: This is also the agent that instructs the next party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    public IParty7Choice? Assigner { get; init; } 
    /// <summary>
    /// Party to which the case is assigned.|Usage: This is also the agent that is instructed by the previous party in the chain to carry out the (set of) cancellation request(s).
    /// </summary>
    public IParty7Choice? Assignee { get; init; } 
    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; } 
    
    #nullable disable
}

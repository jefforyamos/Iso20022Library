﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransactionInformation26.  ISO2002 ID# _P5oQSdp-Ed-ak6NoX_4Aeg_-269295301.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the original transactions, to which the status report message refers.
/// </summary>
public partial record PaymentTransactionInformation26
{
    #nullable enable
    
    /// <summary>
    /// Unique identification, as assigned by an instructing party for an instructed party, to unambiguously identify the reported status.|Usage: The instructing party is the party sending the status message and not the party that sent the original instruction that is being reported on.
    /// </summary>
    public IsoMax35Text? StatusIdentification { get; init; } 
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
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    public TransactionIndividualStatus3Code? TransactionStatus { get; init; } 
    /// <summary>
    /// Set of elements used to provide detailed information on the status reason.
    /// </summary>
    public StatusReasonInformation8[] StatusReasonInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Provides information on the charges related to the processing of the rejection of the instruction.||Usage: This is passed on for information purposes only. Settlement of the charges will be done separately.
    /// </summary>
    public ChargesInformation5[] ChargesInformation { get; init; } = []; // Warning: Don't know multiplicity.
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent. This means that the account servicing agent has received the payment order and has applied checks such as authorisation, availability of funds.
    /// </summary>
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by the account servicing institution, to unambiguously identify the instruction.
    /// </summary>
    public IsoMax35Text? AccountServicerReference { get; init; } 
    /// <summary>
    /// Unique reference, as assigned by a clearing system, to unambiguously identify the instruction.
    /// </summary>
    public IsoMax35Text? ClearingSystemReference { get; init; } 
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).||Usage: The instructing agent is the party sending the status message and not the party that sent the original instruction that is being reported on.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification4? InstructingAgent { get; init; } 
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).||Usage: The instructed agent is the party receiving the status message and not the party that received the original instruction that is being reported on.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification4? InstructedAgent { get; init; } 
    /// <summary>
    /// Set of key elements used to identify the original transaction that is being referred to.
    /// </summary>
    public OriginalTransactionReference13? OriginalTransactionReference { get; init; } 
    
    #nullable disable
}

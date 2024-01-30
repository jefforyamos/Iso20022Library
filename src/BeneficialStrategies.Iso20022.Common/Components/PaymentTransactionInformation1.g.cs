﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentTransactionInformation1.  ISO2002 ID# _PsqLS9p-Ed-ak6NoX_4Aeg_-1746248440.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information concerning the original transactions, to which the status report message refers.
/// </summary>
public partial record PaymentTransactionInformation1
{
    #nullable enable
    
    /// <summary>
    /// Unique identification as assigned by an instructing party for an instructed party to unambiguously identify the reported status.
    /// </summary>
    public IsoMax35Text? StatusIdentification { get; init; } 
    /// <summary>
    /// Unique and unambiguous identifier of the original payment information block as assigned by the original sending party.
    /// </summary>
    public IsoMax35Text? OriginalPaymentInformationIdentification { get; init; } 
    /// <summary>
    /// Original unique instruction identification as assigned by an instructing party for an instructed party to unambiguously identify the original instruction.||Usage: the original instruction identification is the original point to point reference used between the instructing party and the instructed party to refer to the original instruction.
    /// </summary>
    public IsoMax35Text? OriginalInstructionIdentification { get; init; } 
    /// <summary>
    /// Original unique identification assigned by the initiating party to unambiguously identify the original transaction. This identification is passed on, unchanged, throughout the entire end-to-end chain.
    /// </summary>
    public IsoMax35Text? OriginalEndToEndIdentification { get; init; } 
    /// <summary>
    /// Original identification of a transaction, as assigned by the first instructing agent and passed on, unchanged, throughout the entire interbank chain.
    /// </summary>
    public IsoMax35Text? OriginalTransactionIdentification { get; init; } 
    /// <summary>
    /// Specifies the status of a transaction, in a coded form.
    /// </summary>
    public TransactionIndividualStatus1Code? TransactionStatus { get; init; } 
    /// <summary>
    /// Detailed information on the status reason.
    /// </summary>
    public StatusReasonInformation1? StatusReasonInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Information on charges related to the processing of the rejection of the instruction.||Usage: ChargesInformation is past on for information purposes only. Settlement of the charges will be done separately.
    /// </summary>
    public ChargesInformation1? ChargesInformation { get; init;  } // Warning: Don't know multiplicity.
    /// <summary>
    /// Point in time when the payment order from the initiating party meets the processing conditions of the account servicing agent (debtor's agent in case of a credit transfer, creditor's agent in case of a direct debit). This means - amongst others - that the account servicing agent has received the payment order and has applied checks as eg, authorisation, availability of funds.
    /// </summary>
    public IsoISODateTime? AcceptanceDateTime { get; init; } 
    /// <summary>
    /// Agent that instructs the next party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? InstructingAgent { get; init; } 
    /// <summary>
    /// Agent that is instructed by the previous party in the chain to carry out the (set of) instruction(s).
    /// </summary>
    public BranchAndFinancialInstitutionIdentification3? InstructedAgent { get; init; } 
    /// <summary>
    /// Set of key elements of the original transaction being referred to.
    /// </summary>
    public OriginalTransactionReference1? OriginalTransactionReference { get; init; } 
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementInformation16.  ISO2002 ID# _QHfGG9p-Ed-ak6NoX_4Aeg_-1606098687.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements used to provide information on the settlement of the instruction.
/// </summary>
[DataContract]
[XmlType]
public partial record SettlementInformation16
{
    #nullable enable
    
    /// <summary>
    /// Method used to settle the (batch of) payment instructions.
    /// </summary>
    [DataMember]
    public required SettlementMethod1Code SettlementMethod { get; init; } 
    /// <summary>
    /// A specific purpose account used to post debit and credit entries as a result of the transaction.
    /// </summary>
    [DataMember]
    public CashAccount16? SettlementAccount { get; init; } 
    /// <summary>
    /// Specification of a pre-agreed offering between clearing agents or the channel through which the payment instruction is processed.
    /// </summary>
    [DataMember]
    public ClearingSystemIdentification3Choice_? ClearingSystem { get; init; } 
    /// <summary>
    /// Agent through which the instructing agent will reimburse the instructed agent.||Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [DataMember]
    public BranchAndFinancialInstitutionIdentification5? InstructingReimbursementAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the instructing reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [DataMember]
    public CashAccount16? InstructingReimbursementAgentAccount { get; init; } 
    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If InstructedReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.|Usage: If InstructingAgent and InstructedAgent have the same reimbursement agent, then only InstructingReimbursementAgent must be used.
    /// </summary>
    [DataMember]
    public BranchAndFinancialInstitutionIdentification5? InstructedReimbursementAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the instructed reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [DataMember]
    public CashAccount16? InstructedReimbursementAgentAccount { get; init; } 
    /// <summary>
    /// Agent at which the instructed agent will be reimbursed.|Usage: If ThirdReimbursementAgent contains a branch of the InstructedAgent, then the party in InstructedAgent will claim reimbursement from that branch/will be paid by that branch.
    /// </summary>
    [DataMember]
    public BranchAndFinancialInstitutionIdentification5? ThirdReimbursementAgent { get; init; } 
    /// <summary>
    /// Unambiguous identification of the account of the third reimbursement agent account at its servicing agent in the payment chain.
    /// </summary>
    [DataMember]
    public CashAccount16? ThirdReimbursementAgentAccount { get; init; } 
    
    #nullable disable
}

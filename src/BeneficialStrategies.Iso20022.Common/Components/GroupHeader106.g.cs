﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GroupHeader106.  ISO2002 ID# _NKkV8QLGEe2X55dNQNVKfg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
public partial record GroupHeader106
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference assigned by the instructing party and sent to the next party in the chain to unambiguously identify the message.||Usage: The instructing party has to make sure that 'MessageIdentification' is unique per instructed party for a pre-agreed period.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the status report was created by the instructing party.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Party initiating the creditor payment activation request. This can either be the creditor himself or the party that initiates the request on behalf of the creditor.
    /// </summary>
    public required PartyIdentification135 InitiatingParty { get; init; } 
    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain for execution.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? ForwardingAgent { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the debtor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? DebtorAgent { get; init; } 
    /// <summary>
    /// Financial institution servicing an account for the creditor.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? CreditorAgent { get; init; } 
    
    #nullable disable
}

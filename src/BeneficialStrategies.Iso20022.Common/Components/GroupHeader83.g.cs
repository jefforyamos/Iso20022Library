﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for GroupHeader83.  ISO2002 ID# _M_ZMgW49EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of characteristics shared by all individual transactions included in the message.
/// </summary>
public partial record GroupHeader83
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, assigned by the instructing party and sent to the next party in the chain, to unambiguously identify the message.||Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// User identification or any user key that allows to check if the initiating party is allowed to initiate transactions from the account specified in the initiation.||Usage: The content is not of a technical nature, but reflects the organisational structure at the initiating side. The authorisation element can typically be used in relay scenarios, payment initiations, payment returns or payment reversals that are initiated on behalf of a different party than the initiating party.
    /// </summary>
    public Authorisation1Choice_[] Authorisation { get; init; } = [];
    /// <summary>
    /// Number of individual transactions contained in the message.
    /// </summary>
    public required IsoMax15NumericText NumberOfTransactions { get; init; } 
    /// <summary>
    /// Total of all individual amounts included in the message, irrespective of currencies.
    /// </summary>
    public IsoDecimalNumber? ControlSum { get; init; } 
    /// <summary>
    /// Party that initiates the payment.||Usage: This can either be the creditor or a party that initiates the direct debit on behalf of the creditor.
    /// </summary>
    public required PartyIdentification135 InitiatingParty { get; init; } 
    /// <summary>
    /// Financial institution that receives the instruction from the initiating party and forwards it to the next agent in the payment chain for execution.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? ForwardingAgent { get; init; } 
    
    #nullable disable
}

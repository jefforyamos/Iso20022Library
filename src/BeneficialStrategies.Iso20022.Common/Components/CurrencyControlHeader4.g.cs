﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CurrencyControlHeader4.  ISO2002 ID# _73tS0W48EeiU9cctagi5ow.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Characteristics shared by all individual items included in the currency control message.
/// </summary>
public partial record CurrencyControlHeader4
{
    #nullable enable
    
    /// <summary>
    /// Point to point reference, as assigned by the instructing party, and sent to the next party in the chain to unambiguously identify the message.|Usage: The instructing party has to make sure that MessageIdentification is unique per instructed party for a pre-agreed period.
    /// </summary>
    public required IsoMax35Text MessageIdentification { get; init; } 
    /// <summary>
    /// Date and time at which the message was created.
    /// </summary>
    public required IsoISODateTime CreationDateTime { get; init; } 
    /// <summary>
    /// Number of individual items contained in the message.
    /// </summary>
    public required IsoMax15NumericText NumberOfItems { get; init; } 
    /// <summary>
    /// Party that initiates the instruction.
    /// </summary>
    public required PartyIdentification135 InitiatingParty { get; init; } 
    /// <summary>
    /// Agent which forwards the message.
    /// </summary>
    public BranchAndFinancialInstitutionIdentification6? ForwardingAgent { get; init; } 
    
    #nullable disable
}

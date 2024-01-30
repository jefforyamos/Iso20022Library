﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount161.  ISO2002 ID# _3QBbgWpWEeipaMTLlhaKMQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party and account details.
/// </summary>
public partial record PartyIdentificationAndAccount161
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required IPartyIdentification123Choice Identification { get; init; } 
    /// <summary>
    /// Legal Entity Identification as an alternate identification for the party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Alternate identification for the party.
    /// </summary>
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    public SecuritiesAccount19? SafekeepingAccount { get; init; } 
    /// <summary>
    /// Date/time at which the instruction was processed by the specified party.
    /// </summary>
    public IDateAndDateTime2Choice? ProcessingDate { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Additional information about the party.
    /// </summary>
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    
    #nullable disable
}

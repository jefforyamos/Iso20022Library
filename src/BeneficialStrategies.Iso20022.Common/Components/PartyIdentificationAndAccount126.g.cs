﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount126.  ISO2002 ID# _vAhGS4FvEeWtPe6Crjmeug.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party involved in the settlement chain.
/// </summary>
public partial record PartyIdentificationAndAccount126
{
    #nullable enable
    
    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    public required IPartyIdentification100Choice PartyIdentification { get; init; } 
    /// <summary>
    /// Identification of the account owned by the party.
    /// </summary>
    public IsoMax35Text? AccountIdentification { get; init; } 
    /// <summary>
    /// Specifies the reference of the transaction at the party identified in the sequence.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Date and optionally the time, at which this transaction was processed by the party identified in this sequence.
    /// </summary>
    public IDateAndDateTimeChoice? ProcessingDate { get; init; } 
    /// <summary>
    /// Business relationship between two entities; one entity is the account owner, the other entity is the account servicer.
    /// </summary>
    public SubAccount5? SubAccount { get; init; } 
    /// <summary>
    /// Contact person and contact information.
    /// </summary>
    public ContactIdentification2? ContactPerson { get; init; } 
    
    #nullable disable
}

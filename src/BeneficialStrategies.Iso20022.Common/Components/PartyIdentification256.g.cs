﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification256.  ISO2002 ID# _v1YTYYdDEeulCpwZAxK3Uw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification256
{
    #nullable enable
    
    /// <summary>
    /// Identification of the acceptor.
    /// ISO 8583 bit 42
    /// </summary>
    public required IsoMax35Text Identification { get; init; } 
    /// <summary>
    /// Entity in charge of assigning an identification to a party.
    /// </summary>
    public IsoMax35Text? Assigner { get; init; } 
    /// <summary>
    /// Country of the party.
    /// </summary>
    public ISO3NumericCountryCode? Country { get; init; } 
    /// <summary>
    /// Short name of the party.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    /// <summary>
    /// Legal Corporate Name of the party
    /// </summary>
    public IsoMax99Text? LegalCorporateName { get; init; } 
    /// <summary>
    /// Additional identification assigned to the party.
    /// </summary>
    public AdditionalData1? AdditionalIdentification { get; init; } 
    /// <summary>
    /// Name and location of the card acceptor. May contain only the name when the location is specified elsewhere.
    /// </summary>
    public required IsoMax99Text NameAndLocation { get; init; } 
    
    #nullable disable
}

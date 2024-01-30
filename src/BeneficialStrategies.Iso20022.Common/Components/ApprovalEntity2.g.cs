﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ApprovalEntity2.  ISO2002 ID# _tgIE0R1EEey8XKHwKquEQw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity that has delivered or declined the card payment authorisation (the party may be unidentified).
/// </summary>
public partial record ApprovalEntity2
{
    #nullable enable
    
    /// <summary>
    /// Identification of the entity.
    /// ISO 8583:93/2003 bit 58
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Type of entity having declined or delivered the card payment authorisation.
    /// </summary>
    public required PartyType26Code Type { get; init; } 
    /// <summary>
    /// Other type of party.
    /// </summary>
    public IsoMax35Text? OtherType { get; init; } 
    /// <summary>
    /// Entity in charge of assigning the identification.
    /// </summary>
    public PartyType9Code? Assigner { get; init; } 
    /// <summary>
    /// Country of the entity declining or delivering the authorisation.
    /// ISO 3166-1 alpha-2 or alpha-3.
    /// ISO 8583:93 bit 70
    /// </summary>
    public ISOMax3ACountryCode? Country { get; init; } 
    /// <summary>
    /// Short name of the entity delivering or declining the authorisation.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    
    #nullable disable
}

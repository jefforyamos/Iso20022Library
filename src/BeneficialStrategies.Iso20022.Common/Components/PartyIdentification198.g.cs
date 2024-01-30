﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification198.  ISO2002 ID# _LaBAcUrBEeenp6hmNprBHg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification198
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    /// <summary>
    /// Entity in charge of assigning an identification to a party.
    /// </summary>
    public PartyType18Code? Assigner { get; init; } 
    /// <summary>
    /// Country of the party.
    /// </summary>
    public ISO3NumericCountryCode? Country { get; init; } 
    /// <summary>
    /// Short name of the party.
    /// </summary>
    public IsoMax35Text? ShortName { get; init; } 
    
    #nullable disable
}

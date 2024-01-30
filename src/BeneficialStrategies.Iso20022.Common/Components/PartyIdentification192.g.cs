﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification192.  ISO2002 ID# _aW5hYf1REeixXcHVEYIW2g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification192
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    public required IPartyIdentification152Choice Party { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for the party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    
    #nullable disable
}

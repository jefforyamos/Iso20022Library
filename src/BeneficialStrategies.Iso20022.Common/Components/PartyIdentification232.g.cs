﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification232.  ISO2002 ID# _ApvkkMuqEeiWUeUVHQmKaw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
public partial record PartyIdentification232
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    public required PartyIdentification120Choice_ Identification { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Alternate identification for a party.
    /// </summary>
    public AlternatePartyIdentification7? AlternateIdentification { get; init; } 
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification102.  ISO2002 ID# _ckENy5KQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about identification of the party.
/// </summary>
public partial record PartyIdentification102
{
    #nullable enable
    
    /// <summary>
    /// Identification of a party.
    /// </summary>
    public required PartyIdentification111Choice_ Identification { get; init; } 
    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Provides alternate identification for a party using an id type, a country code and a text field.
    /// </summary>
    public AlternatePartyIdentification9[] AlternateIdentification { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

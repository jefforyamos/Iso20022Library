﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentification91.  ISO2002 ID# _ns3w8TqLEeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of an entity involved in an activity.
/// </summary>
public partial record PartyIdentification91
{
    #nullable enable
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required PartyIdentification44Choice_ Identification { get; init; } 
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    public IsoLEIIdentifier? LEI { get; init; } 
    /// <summary>
    /// Unambiguous identification of the transaction for the party identified.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PartyIdentificationAndAccount87.  ISO2002 ID# _2dEw4NonEeCWg-hsBVGrDA_925435149.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
public partial record PartyIdentificationAndAccount87
{
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous way to identify an organisation.
    /// </summary>
    public required PartyIdentification70Choice_ Identification { get; init; } 
    /// <summary>
    /// Reference meaningful to the party identified.
    /// </summary>
    public IsoMax35Text? ProcessingIdentification { get; init; } 
    /// <summary>
    /// Provides additional information regarding the party.
    /// </summary>
    public PartyTextInformation1? AdditionalInformation { get; init; } 
    /// <summary>
    /// Entity involved in an activity.
    /// </summary>
    public AlternatePartyIdentification6? AlternateIdentification { get; init; } 
    
    #nullable disable
}

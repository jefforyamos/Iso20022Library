﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _8GiQF_fREeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat39Choice;

/// <summary>
/// Place of safekeeping expressed with a propriety identification scheme.
/// </summary>
public partial record Proprietary : ISafekeepingPlaceFormat39Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required GenericIdentification47 Type { get; init; } 
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity.
    /// </summary>
    public IsoRestrictedFINXMax30Text? Identification { get; init; } 
    #nullable disable
}

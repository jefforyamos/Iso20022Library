﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _k06gOR5iEeWDV95LUQhXCA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SafekeepingPlaceFormat8Choice;

/// <summary>
/// Place of safekeeping expressed with a propriety identification scheme.
/// </summary>
public partial record Proprietary : ISafekeepingPlaceFormat8Choice
{
    #nullable enable
    /// <summary>
    /// Proprietary information, often a code, issued by the data source scheme issuer.
    /// </summary>
    public required GenericIdentification30 Type { get; init; } 
    /// <summary>
    /// Name or number assigned by an entity to enable recognition of that entity, for example, account identifier.
    /// </summary>
    public IsoMax35Text? Identification { get; init; } 
    #nullable disable
}

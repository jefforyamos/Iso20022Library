﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Natural.  ISO2002 ID# _36SD8O9KEemVGdgB8P8uQQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification235Choice;

/// <summary>
/// The party is a natural person.
/// </summary>
public partial record Natural : IPartyIdentification235Choice
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification of the natural person.
    /// </summary>
    public required GenericIdentification175 Identification { get; init; } 
    /// <summary>
    /// Indicates the name of the natural person.
    /// </summary>
    public IsoMax105Text? Name { get; init; } 
    /// <summary>
    /// Indicates the domicile of the natural person.
    /// </summary>
    public IsoMax500Text? Domicile { get; init; } 
    #nullable disable
}

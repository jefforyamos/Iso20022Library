﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Natural.  ISO2002 ID# _p2YEYMgoEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification236Choice;

/// <summary>
/// Party is a natural person.
/// </summary>
public partial record Natural : IPartyIdentification236Choice
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

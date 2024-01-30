﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NaturalPerson.  ISO2002 ID# _osYgE46XEemzmeK8_tPygg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification205Choice;

/// <summary>
/// Private person.
/// </summary>
public partial record NaturalPerson : IPartyIdentification205Choice
{
    #nullable enable
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    public required PersonName1 NameAndAddress { get; init; } 
    /// <summary>
    /// CONCAT
    /// </summary>
    public required NaturalPersonIdentification1 Identification { get; init; } 
    #nullable disable
}

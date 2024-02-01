﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NaturalPerson.  ISO2002 ID# _pY464_Q0EeqAradXpAelDQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification232Choice;

/// <summary>
/// Private person.
/// </summary>
public partial record NaturalPerson : PartyIdentification232Choice_
{
    #nullable enable
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    public required PersonName3 NameAndAddress { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax256Text? EmailAddress { get; init; } 
    /// <summary>
    /// Natural person local identification and type.
    /// </summary>
    public required NaturalPersonIdentification1 Identification { get; init; } 
    /// <summary>
    /// Nationality of the person.
    /// </summary>
    public CountryCode? Nationality { get; init; } 
    /// <summary>
    /// Date on which and place at which a born person is born.
    /// </summary>
    public DateAndPlaceOfBirth2? DateAndPlaceOfBirth { get; init; } 
    #nullable disable
}

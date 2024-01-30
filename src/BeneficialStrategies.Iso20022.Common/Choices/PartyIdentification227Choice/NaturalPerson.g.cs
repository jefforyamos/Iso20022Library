﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NaturalPerson.  ISO2002 ID# _B1TxNK-mEemJ1NnLPsTFaw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification227Choice;

/// <summary>
/// Private person.
/// </summary>
public partial record NaturalPerson : IPartyIdentification227Choice
{
    #nullable enable
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    public required PersonName1 NameAndAddress { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax256Text? EmailAddress { get; init; } 
    /// <summary>
    /// Natural person local identification and type.
    /// </summary>
    public NaturalPersonIdentification1? Identification { get; init; } 
    #nullable disable
}

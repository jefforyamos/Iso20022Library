﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LegalPerson.  ISO2002 ID# _3Ep6xLIFEemux5trsZcCpw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification228Choice;

/// <summary>
/// Legal entity.
/// </summary>
public partial record LegalPerson : IPartyIdentification228Choice
{
    #nullable enable
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    public required PersonName2 NameAndAddress { get; init; } 
    /// <summary>
    /// Address for electronic mail (e-mail).
    /// </summary>
    public IsoMax256Text? EmailAddress { get; init; } 
    /// <summary>
    /// Identification of the party.
    /// </summary>
    public required IPartyIdentification198Choice Identification { get; init; } 
    #nullable disable
}

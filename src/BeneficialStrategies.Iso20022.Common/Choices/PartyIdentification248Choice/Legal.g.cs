﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Legal.  ISO2002 ID# _WAhpkT3YEe2uHKhHp3bXyA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PartyIdentification248Choice;

/// <summary>
/// Party is a legal person.
/// </summary>
public partial record Legal : PartyIdentification248Choice_
{
    #nullable enable
    /// <summary>
    /// Unique and unambiguous identification of the legal person.
    /// </summary>
    public required OrganisationIdentification15Choice_ Identification { get; init; } 
    /// <summary>
    /// Code of country where the registered office of the organisation is located.
    /// </summary>
    public CountryCode? Country { get; init; } 
    #nullable disable
}

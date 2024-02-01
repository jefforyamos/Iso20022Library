﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PersonName.  ISO2002 ID# _RE37YNp-Ed-ak6NoX_4Aeg_1465032202.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IndividualPersonIdentificationChoice;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record PersonName : IndividualPersonIdentificationChoice_
{
    #nullable enable
    /// <summary>
    /// First name of a person.
    /// </summary>
    public required IsoMax35Text GivenName { get; init; } 
    /// <summary>
    /// Second name of a person.
    /// </summary>
    public IsoMax35Text? MiddleName { get; init; } 
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Specifies the gender of the person.
    /// </summary>
    public GenderCode? Gender { get; init; } 
    /// <summary>
    /// Date on which a person is born.
    /// </summary>
    public IsoISODate? BirthDate { get; init; } 
    #nullable disable
}

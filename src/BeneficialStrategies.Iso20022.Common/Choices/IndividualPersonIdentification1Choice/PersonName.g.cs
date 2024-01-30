﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PersonName.  ISO2002 ID# _g3i8IyFWEeWgV9SQSyaAog.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.IndividualPersonIdentification1Choice;

/// <summary>
/// Name of the person that owns the account.
/// </summary>
public partial record PersonName : IIndividualPersonIdentification1Choice
{
    #nullable enable
    /// <summary>
    /// First name of the person.
    /// </summary>
    public IsoMax35Text? GivenName { get; init; } 
    /// <summary>
    /// Second name of the person.
    /// </summary>
    public IsoMax35Text? MiddleName { get; init; } 
    /// <summary>
    /// Name by which the party is known and which is usually used to identify that party.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Gender of the person.
    /// </summary>
    public GenderCode? Gender { get; init; } 
    /// <summary>
    /// Date on which the person is born.
    /// </summary>
    public IsoISODate? BirthDate { get; init; } 
    #nullable disable
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for IndividualPerson.  ISO2002 ID# _w5-30FxYEeWvPv3PXpS3fw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RegisteredShareholderName1Choice;

/// <summary>
/// Human entity, as distinguished from a corporate entity (which is sometimes referred to as an 'artificial person').
/// </summary>
public partial record IndividualPerson : IRegisteredShareholderName1Choice
{
    #nullable enable
    /// <summary>
    /// Term used to address the person.
    /// </summary>
    public INamePrefix1Choice? NamePrefix { get; init; } 
    /// <summary>
    /// First name of the person.
    /// </summary>
    public IsoMax35Text? GivenName { get; init; } 
    /// <summary>
    /// Second name of the person.
    /// </summary>
    public IsoMax35Text? MiddleName { get; init; } 
    /// <summary>
    /// Name by which the party is known and which is usually used to identify that person.
    /// </summary>
    public required IsoMax350Text Name { get; init; } 
    /// <summary>
    /// Address of the person.
    /// </summary>
    // public IReadOnlyCollection<PostalAddress21> PostalAddress { get; init; }
    #nullable disable
}

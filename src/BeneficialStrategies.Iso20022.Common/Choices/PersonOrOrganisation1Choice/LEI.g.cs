﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LEI.  ISO2002 ID# _gOV-kgkiEeWGouz230Xp5Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PersonOrOrganisation1Choice;

/// <summary>
/// Legal entity identifier of the party.
/// </summary>
public partial record LEI : IPersonOrOrganisation1Choice
{
    public required IsoLEIIdentifier Value { get; init; }
}

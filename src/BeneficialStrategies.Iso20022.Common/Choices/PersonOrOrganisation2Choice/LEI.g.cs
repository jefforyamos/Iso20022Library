﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for LEI.  ISO2002 ID# _-GX-QQkiEeWGouz230Xp5Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PersonOrOrganisation2Choice;

/// <summary>
/// Legal entity identifier of the party.
/// </summary>
public partial record LEI : IPersonOrOrganisation2Choice
{
    public required IsoLEIIdentifier Value { get; init; }
}

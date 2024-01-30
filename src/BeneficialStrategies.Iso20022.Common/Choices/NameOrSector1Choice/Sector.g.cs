﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Sector.  ISO2002 ID# _6URv4YInEeWA9fc11zJf1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NameOrSector1Choice;

/// <summary>
/// Represents the counterparty institutional section (such as non-financial corporation, central bank.).
/// </summary>
public partial record Sector : INameOrSector1Choice
{
    public required IsoSNA2008SectorIdentifier Value { get; init; }
}

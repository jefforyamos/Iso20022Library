﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _lG0rRYnnEeOORMXOfBk1Bw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.GarnishmentType1Choice;

/// <summary>
/// Proprietary identification of the type of garnishment.
/// </summary>
public partial record Proprietary : IGarnishmentType1Choice
{
    public required IsoMax35Text Value { get; init; }
}

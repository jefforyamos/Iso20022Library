﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _Zzxz8_F6EemQ7oqCO5NTQw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ServiceStatus1Choice;

/// <summary>
/// Status, in a proprietary form.
/// </summary>
public partial record Proprietary : IServiceStatus1Choice
{
    public required IsoMax35Text Value { get; init; }
}

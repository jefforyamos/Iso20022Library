﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _Su5UCgEcEeCQm6a_G2yO_w_-785385241.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Status6Choice;

/// <summary>
/// Status expressed as a proprietary form.
/// </summary>
public partial record Proprietary : Status6Choice_
{
    public required IsoMax35Text Value { get; init; }
}

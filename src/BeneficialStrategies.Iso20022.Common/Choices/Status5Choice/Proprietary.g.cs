﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _Su5UDQEcEeCQm6a_G2yO_w_670281119.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Status5Choice;

/// <summary>
/// Status expressed as a proprietary form.
/// </summary>
public partial record Proprietary : IStatus5Choice
{
    public required IsoMax35Text Value { get; init; }
}

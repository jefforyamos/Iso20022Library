﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _D4edcBg3EeKnW4lR85q-0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Channel2Choice;

/// <summary>
/// Specifies a channel by means of a text.
/// </summary>
public partial record Proprietary : Channel2Choice_
{
    public required IsoMax35Text Value { get; init; }
}

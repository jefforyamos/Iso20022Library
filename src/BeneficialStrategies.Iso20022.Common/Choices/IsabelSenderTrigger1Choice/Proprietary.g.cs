﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _fqK-IMmLEeWAGphE2LvqeA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IsabelSenderTrigger1Choice;

/// <summary>
/// Trigger used by the sender to generate the file, in a proprietary form.
/// </summary>
public partial record Proprietary : IIsabelSenderTrigger1Choice
{
    public required IsoMax4AlphaNumericText Value { get; init; }
}

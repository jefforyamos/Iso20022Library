﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _jG-UEe5NEeCisYr99QEiWA_-734160402.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason16Choice;

/// <summary>
/// Reason for the cancellation request, in a proprietary form.
/// </summary>
public partial record Proprietary : CancellationReason16Choice_
{
    public required IsoMax35Text Value { get; init; }
}

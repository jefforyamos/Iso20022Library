﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _wsiMNUgtEeaGKYpLDboHPQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason33Choice;

/// <summary>
/// Reason for the cancellation request, in a proprietary form.
/// </summary>
public partial record Proprietary : ICancellationReason33Choice
{
    public required IsoMax35Text Value { get; init; }
}

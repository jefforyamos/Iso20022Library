﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _E3LrMViCEea0N7AwCvR5KA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason32Choice;

/// <summary>
/// Cancellation reason expressed as a code.
/// </summary>
public partial record Code : CancellationReason32Choice_
{
    public required IsoMax35Text Value { get; init; }
}

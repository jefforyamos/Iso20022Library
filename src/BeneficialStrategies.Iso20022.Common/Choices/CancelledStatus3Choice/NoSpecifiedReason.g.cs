﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _V4EH7-JxEd-Q6MzBzY5WkA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledStatus3Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NoSpecifiedReason : CancelledStatus3Choice_
{
    public required NoReasonCode Value { get; init; }
}

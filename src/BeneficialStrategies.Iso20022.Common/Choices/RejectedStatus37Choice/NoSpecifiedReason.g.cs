﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _GRg7URHqEeuE0Pnt-OcNOA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus37Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NoSpecifiedReason : IRejectedStatus37Choice
{
    public required NoReasonCode Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _XAGOcEh7EeOUboEk24drjw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AcceptedStatus4Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NoSpecifiedReason : IAcceptedStatus4Choice
{
    public required NoReasonCode Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _tRI8UUGSEeWqy4niLuXETA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus41Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NoSpecifiedReason : PendingStatus41Choice_
{
    public required NoReasonCode Value { get; init; }
}

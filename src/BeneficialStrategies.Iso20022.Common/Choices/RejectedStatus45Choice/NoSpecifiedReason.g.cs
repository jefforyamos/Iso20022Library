﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _pf-JVzi7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus45Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NoSpecifiedReason : IRejectedStatus45Choice
{
    public required NoReasonCode Value { get; init; }
}

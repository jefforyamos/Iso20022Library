﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _kov6lZwsEeazcsnODTksnQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingStatus53Choice;

/// <summary>
/// Reason not specified.
/// </summary>
public partial record NoSpecifiedReason : PendingStatus53Choice_
{
    public required NoReasonCode Value { get; init; }
}

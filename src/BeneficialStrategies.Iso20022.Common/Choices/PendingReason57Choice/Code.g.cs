﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Gbs8Ie6KEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason57Choice;

/// <summary>
/// Standard code to specify the reason why the instruction/event has a pending status.
/// </summary>
public partial record Code : PendingReason57Choice_
{
    public required PendingReason20Code Value { get; init; }
}

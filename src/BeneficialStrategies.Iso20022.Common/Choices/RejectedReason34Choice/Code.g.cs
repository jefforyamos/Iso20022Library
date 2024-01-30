﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _cw5yoe6BEeqc-LCjwLsUVg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason34Choice;

/// <summary>
/// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
/// </summary>
public partial record Code : IRejectedReason34Choice
{
    public required RejectionReason56Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _piJT8Ti7Eeydid5dcNPKvg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason46Choice;

/// <summary>
/// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
/// </summary>
public partial record Code : IRejectedReason46Choice
{
    public required RejectionReason66Code Value { get; init; }
}

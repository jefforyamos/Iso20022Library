﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _qNRpobXTEeiTob_PrFFUxA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason24Choice;

/// <summary>
/// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
/// </summary>
public partial record Code : IRejectedReason24Choice
{
    public required RejectionReason48Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _bzV1j_fREeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason26Choice;

/// <summary>
/// Standard code to specify the reason why the instruction/cancellation request has a rejected status.
/// </summary>
public partial record Code : RejectedReason26Choice_
{
    public required RejectionReason48Code Value { get; init; }
}

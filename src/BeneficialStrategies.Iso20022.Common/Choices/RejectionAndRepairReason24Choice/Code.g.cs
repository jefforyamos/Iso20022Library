﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _WVswUzq4EeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RejectionAndRepairReason24Choice;

/// <summary>
/// Specifies the reason why the instruction/request has a repair or rejection status.
/// </summary>
public partial record Code : IRejectionAndRepairReason24Choice
{
    public required RejectionReason32Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _0bSpsTqeEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepairReason10Choice;

/// <summary>
/// Specifies the reason why the instruction/request has a repair or rejection status.
/// </summary>
public partial record Code : IRepairReason10Choice
{
    public required RepairReason4Code Value { get; init; }
}

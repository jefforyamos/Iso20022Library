﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _hP47sQd3Ee2fOITqoTnSLQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepairReason19Choice;

/// <summary>
/// Specifies the reason why the instruction/request has a repair or rejection status.
/// </summary>
public partial record Code : RepairReason19Choice_
{
    public required RepairReason7Code Value { get; init; }
}

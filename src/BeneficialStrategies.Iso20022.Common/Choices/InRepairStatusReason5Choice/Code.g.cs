﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _P8QicUHqEea8I67lh6qdSQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InRepairStatusReason5Choice;

/// <summary>
/// In repair reason expressed as a code.
/// </summary>
public partial record Code : InRepairStatusReason5Choice_
{
    public required InRepairStatusReason1Code Value { get; init; }
}

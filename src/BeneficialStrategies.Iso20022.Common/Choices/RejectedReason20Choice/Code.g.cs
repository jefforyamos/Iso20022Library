﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _aciugUHjEea8I67lh6qdSQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RejectedReason20Choice;

/// <summary>
/// Rejected reason expressed as a code.
/// </summary>
public partial record Code : RejectedReason20Choice_
{
    public required RejectedStatusReason11Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _hKmWkQd4Ee2fOITqoTnSLQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedReason32Choice;

/// <summary>
/// Specifies the reason why the instruction has an unmatched status.
/// </summary>
public partial record Code : IUnmatchedReason32Choice
{
    public required UnmatchedReason4Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _NUMSITs9EeWRTLSN0i0tng.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason21Choice;

/// <summary>
/// Specifies the reason why the related instruction is cancelled, or the related cancellation request is executed.
/// </summary>
public partial record Code : ICancellationReason21Choice
{
    public required CancelledStatusReason5Code Value { get; init; }
}

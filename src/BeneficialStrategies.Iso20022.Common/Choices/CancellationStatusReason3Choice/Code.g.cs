﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _sx1XQ4lrEeePr-EGJjGYzQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationStatusReason3Choice;

/// <summary>
/// Reason for the cancellation status, in a coded form.
/// </summary>
public partial record Code : CancellationStatusReason3Choice_
{
    public required ExternalPaymentCancellationRejection1Code Value { get; init; }
}

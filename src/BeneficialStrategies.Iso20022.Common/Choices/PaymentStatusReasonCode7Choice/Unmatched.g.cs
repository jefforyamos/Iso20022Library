﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Unmatched.  ISO2002 ID# _Ny9DwZlPEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReasonCode7Choice;

/// <summary>
/// Reason why the payment status is unmatched.
/// </summary>
public partial record Unmatched : PaymentStatusReasonCode7Choice_
{
    public required UnmatchedStatusReason1Code Value { get; init; }
}

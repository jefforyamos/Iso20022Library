﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Cancelled.  ISO2002 ID# _QWOzs9EdEei798TPbKJMuw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReason1Choice;

/// <summary>
/// Reason why the payment status is cancelled.
/// </summary>
public partial record Cancelled : IPaymentStatusReason1Choice
{
    public required CancelledStatusReason1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingSettlement.  ISO2002 ID# _QWOzudEdEei798TPbKJMuw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReason1Choice;

/// <summary>
/// Reason why the payment status is pending (settlement).
/// </summary>
public partial record PendingSettlement : IPaymentStatusReason1Choice
{
    public required PendingSettlement2Code Value { get; init; }
}

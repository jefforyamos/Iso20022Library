﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingSettlement.  ISO2002 ID# _Ny9DyZlPEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReasonCode7Choice;

/// <summary>
/// Reason why the payment status is pending (settlement).
/// </summary>
public partial record PendingSettlement : IPaymentStatusReasonCode7Choice
{
    public required PendingSettlement2Code Value { get; init; }
}

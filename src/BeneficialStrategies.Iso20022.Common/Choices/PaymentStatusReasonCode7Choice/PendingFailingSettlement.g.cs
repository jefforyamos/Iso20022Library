﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingFailingSettlement.  ISO2002 ID# _Ny9Dx5lPEee-Zps0fZQaFQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusReasonCode7Choice;

/// <summary>
/// Reason why the payment status is pending (failing settlement).
/// </summary>
public partial record PendingFailingSettlement : PaymentStatusReasonCode7Choice_
{
    public required PendingFailingSettlement1Code Value { get; init; }
}

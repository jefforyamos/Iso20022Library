﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingStatus.  ISO2002 ID# _RF7ESNp-Ed-ak6NoX_4Aeg_2006585750.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode3Choice;

/// <summary>
/// Qualifies further the pending status.
/// </summary>
public partial record PendingStatus : IPaymentStatusCode3Choice
{
    public required PendingStatus4Code Value { get; init; }
}

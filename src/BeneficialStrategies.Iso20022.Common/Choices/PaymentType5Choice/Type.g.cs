﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Type.  ISO2002 ID# _nQ0J4ekAEemV35DUs8L82Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentType5Choice;

/// <summary>
/// Type, or nature, of the payment.
/// </summary>
public partial record Type : IPaymentType5Choice
{
    public required PaymentType4Code Value { get; init; }
}

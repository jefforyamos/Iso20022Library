﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Final.  ISO2002 ID# _phD1BRbzEeOy-PlRuFSUzQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode6Choice;

/// <summary>
/// Qualifies further the final status.
/// </summary>
public partial record Final : IPaymentStatusCode6Choice
{
    public required FinalStatus1Code Value { get; init; }
}

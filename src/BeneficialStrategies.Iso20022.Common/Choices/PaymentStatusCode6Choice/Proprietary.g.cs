﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _phD1CxbzEeOy-PlRuFSUzQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentStatusCode6Choice;

/// <summary>
/// Qualifies further the proprietary status.
/// </summary>
public partial record Proprietary : IPaymentStatusCode6Choice
{
    public required IsoMax35Text Value { get; init; }
}

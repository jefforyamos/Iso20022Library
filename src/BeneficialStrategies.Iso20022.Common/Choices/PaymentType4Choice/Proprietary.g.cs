﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _K7v_8xbwEeOy-PlRuFSUzQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PaymentType4Choice;

/// <summary>
/// Payment type that is not included in a predefined list.
/// </summary>
public partial record Proprietary : IPaymentType4Choice
{
    public required IsoMax35Text Value { get; init; }
}

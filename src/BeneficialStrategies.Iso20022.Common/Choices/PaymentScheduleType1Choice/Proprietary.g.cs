﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _U1OI4AqQEeWqX7rjSIiMuQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentScheduleType1Choice;

/// <summary>
/// Payment schedule type defined in a proprietary format.
/// </summary>
public partial record Proprietary : IPaymentScheduleType1Choice
{
    public required IsoMax35Text Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Special.  ISO2002 ID# _9Q_E4MVaEeiYpLQka876sg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TimeToMaturity1Choice;

/// <summary>
/// Provides the time to maturity when no period is provide.
/// </summary>
public partial record Special : TimeToMaturity1Choice_
{
    public required SpecialPurpose2Code Value { get; init; }
}

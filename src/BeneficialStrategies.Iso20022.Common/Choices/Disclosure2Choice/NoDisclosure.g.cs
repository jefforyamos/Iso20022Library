﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoDisclosure.  ISO2002 ID# _MM9hYfNyEeqRfth943bvEA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.Disclosure2Choice;

/// <summary>
/// Shareholding information is not disclosed.
/// </summary>
public partial record NoDisclosure : IDisclosure2Choice
{
    public required NoReasonCode Value { get; init; }
}

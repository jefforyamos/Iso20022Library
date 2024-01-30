﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _MBEjcyjFEeuKKc2MztSwPw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.FloatingRateIdentification4Choice;

/// <summary>
/// Defines a floating rate which is not included in the list of predefined floating curves.
/// </summary>
public partial record Proprietary : IFloatingRateIdentification4Choice
{
    public required IsoMax350Text Value { get; init; }
}

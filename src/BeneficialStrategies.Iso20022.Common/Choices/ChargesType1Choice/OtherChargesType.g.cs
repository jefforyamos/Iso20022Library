﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for OtherChargesType.  ISO2002 ID# _9WlysBrdEeOVR9VN6fAMUg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ChargesType1Choice;

/// <summary>
/// Specifies the type of charge by means of a free text.
/// </summary>
public partial record OtherChargesType : IChargesType1Choice
{
    public required IsoMax35Text Value { get; init; }
}

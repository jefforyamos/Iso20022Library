﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _kMkhAFKiEeiSDqv62fL07g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DrawdownStatus1Choice;

/// <summary>
/// Status expressed as a code.
/// </summary>
public partial record Code : IDrawdownStatus1Choice
{
    public required DrawdownStatus1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ItKLUDcTEeiIxKQErQxblg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TargetMarket1Choice;

/// <summary>
/// Specifies whether the product is aimed at the target expressed as a code.
/// </summary>
public partial record Code : ITargetMarket1Choice
{
    public required TargetMarket1Code Value { get; init; }
}

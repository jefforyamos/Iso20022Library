﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _BlYN0LTqEeiENt6AoDfPXg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PensionOrderType1Choice;

/// <summary>
/// Type of order attached to the pension policy, plan or scheme expressed as a code.
/// </summary>
public partial record Code : IPensionOrderType1Choice
{
    public required PensionOrderType1Code Value { get; init; }
}

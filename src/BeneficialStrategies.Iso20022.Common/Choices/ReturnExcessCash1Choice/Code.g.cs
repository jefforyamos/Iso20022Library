﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UN9QYALpEeutW5-TpeYJhA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ReturnExcessCash1Choice;

/// <summary>
/// Return excess cash type expressed as a code.
/// </summary>
public partial record Code : IReturnExcessCash1Choice
{
    public required ReturnExcessCash1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _8QboZ5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.AllocationSatus4Choice;

/// <summary>
/// Provides the status of allocation of collateral to cover the instruction.
/// </summary>
public partial record Code : IAllocationSatus4Choice
{
    public required AllocationStatus1Code Value { get; init; }
}

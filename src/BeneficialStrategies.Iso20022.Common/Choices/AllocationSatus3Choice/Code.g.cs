﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _EAk7gTqqEeWyoP0PbocV1Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AllocationSatus3Choice;

/// <summary>
/// Provides the status of allocation of collateral to cover the instruction.
/// </summary>
public partial record Code : IAllocationSatus3Choice
{
    public required AllocationStatus1Code Value { get; init; }
}

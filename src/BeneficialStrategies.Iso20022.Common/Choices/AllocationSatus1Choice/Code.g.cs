﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UX39MNp-Ed-ak6NoX_4Aeg_-2141684730.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AllocationSatus1Choice;

/// <summary>
/// Provides the status of allocation of collateral to cover the instruction.
/// </summary>
public partial record Code : AllocationSatus1Choice_
{
    public required AllocationStatus1Code Value { get; init; }
}

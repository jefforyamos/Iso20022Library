﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UYBuNNp-Ed-ak6NoX_4Aeg_-707074174.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason3Choice;

/// <summary>
/// Specifies the reason why the instruction has a pending status.
/// </summary>
public partial record Code : IPendingReason3Choice
{
    public required PendingReason3Code Value { get; init; }
}

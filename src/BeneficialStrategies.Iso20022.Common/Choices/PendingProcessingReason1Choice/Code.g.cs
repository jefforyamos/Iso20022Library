﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UZXyANp-Ed-ak6NoX_4Aeg_-1812988032.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.PendingProcessingReason1Choice;

/// <summary>
/// Specifies the reason why the instruction has a pending processing status.
/// </summary>
public partial record Code : IPendingProcessingReason1Choice
{
    public required PendingProcessingReason1Code Value { get; init; }
}

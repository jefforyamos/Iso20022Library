﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UYoLJtp-Ed-ak6NoX_4Aeg_-1899691017.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.RepairReason1Choice;

/// <summary>
/// Specifies the reason why the instruction/request has a repair or rejection status.
/// </summary>
public partial record Code : IRepairReason1Choice
{
    public required RepairReason4Code Value { get; init; }
}

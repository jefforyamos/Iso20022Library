﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QxqEd9p-Ed-ak6NoX_4Aeg_-168728675.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingReason4Choice;

/// <summary>
/// Standard code to specify the reason why the instruction/event has a pending status.
/// </summary>
public partial record Code : PendingReason4Choice_
{
    public required PendingReason4Code Value { get; init; }
}

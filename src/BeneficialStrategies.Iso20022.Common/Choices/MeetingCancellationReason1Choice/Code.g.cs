﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RCWL0tp-Ed-ak6NoX_4Aeg_-1788860770.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MeetingCancellationReason1Choice;

/// <summary>
/// Specifies the reason for cancelling a meeting in coded form.
/// </summary>
public partial record Code : IMeetingCancellationReason1Choice
{
    public required MeetingCancellationReason2Code Value { get; init; }
}

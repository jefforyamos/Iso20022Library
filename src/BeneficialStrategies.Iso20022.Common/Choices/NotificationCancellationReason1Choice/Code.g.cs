﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _4g3B0yv_Eey3nPxW-HgLUw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NotificationCancellationReason1Choice;

/// <summary>
/// Reason for the cancellation request, in a coded form.
/// </summary>
public partial record Code : INotificationCancellationReason1Choice
{
    public required ExternalNotificationCancellationReason1Code Value { get; init; }
}

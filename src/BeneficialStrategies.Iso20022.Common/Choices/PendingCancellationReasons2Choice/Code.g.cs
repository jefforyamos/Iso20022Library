﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UYBuN9p-Ed-ak6NoX_4Aeg_-1094614547.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PendingCancellationReasons2Choice;

/// <summary>
/// Specifies the reason why the cancellation request is pending.
/// </summary>
public partial record Code : IPendingCancellationReasons2Choice
{
    public required PendingReason7Code Value { get; init; }
}

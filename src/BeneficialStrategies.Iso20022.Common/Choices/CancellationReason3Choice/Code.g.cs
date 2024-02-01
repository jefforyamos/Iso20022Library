﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UXIWU9p-Ed-ak6NoX_4Aeg_1110686099.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancellationReason3Choice;

/// <summary>
/// Specifies the reason why the related instruction is cancelled, or the related cancellation request is executed.
/// </summary>
public partial record Code : CancellationReason3Choice_
{
    public required CancelledStatusReason5Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _QysmSdp-Ed-ak6NoX_4Aeg_503789638.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledReason1Choice;

/// <summary>
/// Standard code to specify the reason why the instruction is cancelled.
/// </summary>
public partial record Code : CancelledReason1Choice_
{
    public required CancelledStatusReason6Code Value { get; init; }
}

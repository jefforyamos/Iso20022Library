﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Reason.  ISO2002 ID# _RiFb1Np-Ed-ak6NoX_4Aeg_-275254334.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CancelledStatusReason1Choice;

/// <summary>
/// Reason for the cancelled status.
/// </summary>
public partial record Reason : ICancelledStatusReason1Choice
{
    public required CancelledStatusReason2Code Value { get; init; }
}

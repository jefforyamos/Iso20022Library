﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for NoSpecifiedReason.  ISO2002 ID# _RgmOE9p-Ed-ak6NoX_4Aeg_63608102.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ConditionallyAcceptedStatusReason1Choice;

/// <summary>
/// Indicates that there is no reason available or to report.
/// </summary>
public partial record NoSpecifiedReason : IConditionallyAcceptedStatusReason1Choice
{
    public required NoReasonCode Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _UX39Ntp-Ed-ak6NoX_4Aeg_1867774131.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DeniedReason1Choice;

/// <summary>
/// Specifies the reason why the request was denied.
/// </summary>
public partial record Code : IDeniedReason1Choice
{
    public required DeniedReason5Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _fBNm0UHTEeasdbKMiqizqA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CancelledReason12Choice;

/// <summary>
/// Cancelled reason expressed as a code.
/// </summary>
public partial record Code : ICancelledReason12Choice
{
    public required CancelledStatusReason2Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _OEuZkSwZEeOEV5XHD-BKpw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnmatchedReason14Choice;

/// <summary>
/// Specifies the reason why the instruction has an unmatched status.
/// </summary>
public partial record Code : IUnmatchedReason14Choice
{
    public required UnmatchedReason8Code Value { get; init; }
}

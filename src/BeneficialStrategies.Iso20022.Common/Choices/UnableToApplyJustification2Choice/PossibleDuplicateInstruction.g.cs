﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PossibleDuplicateInstruction.  ISO2002 ID# _T-i3Ntp-Ed-ak6NoX_4Aeg_1279007626.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.UnableToApplyJustification2Choice;

/// <summary>
/// Indicates whether or not the referred item is a possible duplicate of a previous instruction or entry.
/// </summary>
public partial record PossibleDuplicateInstruction : IUnableToApplyJustification2Choice
{
    public required IsoTrueFalseIndicator Value { get; init; }
}

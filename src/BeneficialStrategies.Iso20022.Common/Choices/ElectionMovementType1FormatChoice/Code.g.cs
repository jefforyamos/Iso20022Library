﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RmjsINp-Ed-ak6NoX_4Aeg_2024835239.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.ElectionMovementType1FormatChoice;

/// <summary>
/// Standard code to specify the effect on the holdings of electing a Corporate Action option.
/// </summary>
public partial record Code : IElectionMovementType1FormatChoice
{
    public required ElectionMovementType1Code Value { get; init; }
}

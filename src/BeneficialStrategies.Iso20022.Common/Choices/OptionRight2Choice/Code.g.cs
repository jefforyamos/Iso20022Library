﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _P_xv0ZEjEeakHoV5BVecAQ.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OptionRight2Choice;

/// <summary>
/// Option rights expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IOptionRight2Choice
{
    public required OptionRight1Code Value { get; init; }
}

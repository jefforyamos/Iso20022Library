﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q48_Sdp-Ed-ak6NoX_4Aeg_1446763067.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.DateCode3Choice;

/// <summary>
/// Standard code to indicate the date is unknown.
/// </summary>
public partial record Code : IDateCode3Choice
{
    public required DateType1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q4NYY9p-Ed-ak6NoX_4Aeg_1189669056.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.OptionStyle4Choice;

/// <summary>
/// Option style expressed as an ISO 20022 code.
/// </summary>
public partial record Code : IOptionStyle4Choice
{
    public required OptionStyle2Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q3K2kNp-Ed-ak6NoX_4Aeg_330230362.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.LotteryTypeFormat1Choice;

/// <summary>
/// Standard code to specify the type of lottery announced.
/// </summary>
public partial record Code : ILotteryTypeFormat1Choice
{
    public required LotteryType1Code Value { get; init; }
}

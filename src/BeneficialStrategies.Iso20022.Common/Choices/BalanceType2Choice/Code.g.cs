﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RcH9w9p-Ed-ak6NoX_4Aeg_1127274794.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType2Choice;

/// <summary>
/// Specifies the code for the type of a balance, eg, opening booked balance.
/// </summary>
public partial record Code : IBalanceType2Choice
{
    public required BalanceType9Code Value { get; init; }
}

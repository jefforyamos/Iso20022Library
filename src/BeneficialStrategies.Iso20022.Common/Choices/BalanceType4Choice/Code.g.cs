﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RcRuwdp-Ed-ak6NoX_4Aeg_-1171282174.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType4Choice;

/// <summary>
/// Specifies the code for the type of a balance, eg, opening booked balance.
/// </summary>
public partial record Code : IBalanceType4Choice
{
    public required BalanceType11Code Value { get; init; }
}

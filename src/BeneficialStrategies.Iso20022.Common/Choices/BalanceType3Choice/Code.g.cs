﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _RcRuxNp-Ed-ak6NoX_4Aeg_-1428944466.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType3Choice;

/// <summary>
/// Specifies the code for the type of a balance, eg, opening booked balance.
/// </summary>
public partial record Code : IBalanceType3Choice
{
    public required BalanceType10Code Value { get; init; }
}

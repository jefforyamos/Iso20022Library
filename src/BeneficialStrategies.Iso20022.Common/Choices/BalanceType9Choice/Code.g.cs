﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _77AUUqMgEeCJ6YNENx4h-w_609741360.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType9Choice;

/// <summary>
/// Specifies the nature of a balance, in a coded form.
/// </summary>
public partial record Code : IBalanceType9Choice
{
    public required SystemBalanceType2Code Value { get; init; }
}

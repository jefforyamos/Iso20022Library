﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _nArEUvNBEeCuA5Tr22BnwA_-353374082.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BalanceType6Choice;

/// <summary>
/// Balance type expressed in coded form.
/// </summary>
public partial record Code : BalanceType6Choice_
{
    public required BalanceType13Code Value { get; init; }
}

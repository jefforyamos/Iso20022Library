﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Amount.  ISO2002 ID# _VMB-Cdp-Ed-ak6NoX_4Aeg_864900637.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AmountPrice1Choice;

/// <summary>
/// Amount.
/// </summary>
public partial record Amount : IAmountPrice1Choice
{
    public required IsoCurrencyAndAmount Value { get; init; }
}

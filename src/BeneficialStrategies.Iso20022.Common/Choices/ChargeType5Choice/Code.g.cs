﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _-Oqwojh4EeaH-93K5JKmzw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType5Choice;

/// <summary>
/// Fee (charge/commission) expressed as a code.
/// </summary>
public partial record Code : IChargeType5Choice
{
    public required InvestmentFundFee1Code Value { get; init; }
}

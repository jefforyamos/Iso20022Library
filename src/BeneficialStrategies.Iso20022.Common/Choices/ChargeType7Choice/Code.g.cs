﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _zDuYMDcnEeidBoT_PugKiA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType7Choice;

/// <summary>
/// Cost or charge expressed as a code.
/// </summary>
public partial record Code : IChargeType7Choice
{
    public required InvestmentFundMiFIDFee1Code Value { get; init; }
}

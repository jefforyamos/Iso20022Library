﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Rate.  ISO2002 ID# _UPO-kNp-Ed-ak6NoX_4Aeg_282901403.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateAndAmountFormat3Choice;

/// <summary>
/// Value expressed as a rate.
/// </summary>
public partial record Rate : IRateAndAmountFormat3Choice
{
    public required IsoPercentageRate Value { get; init; }
}

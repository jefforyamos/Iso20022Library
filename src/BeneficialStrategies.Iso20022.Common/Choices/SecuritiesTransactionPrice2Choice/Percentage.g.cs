﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Percentage.  ISO2002 ID# _xZe0uyZJEeWbypuCUIOnzw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice2Choice;

/// <summary>
/// Price expressed as a rate, that is a percentage.
/// </summary>
public partial record Percentage : SecuritiesTransactionPrice2Choice_
{
    public required IsoPercentageRate Value { get; init; }
}

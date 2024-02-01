﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Percentage.  ISO2002 ID# _lD0CYMgqEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice19Choice;

/// <summary>
/// Price expressed as a rate, that is a percentage.
/// </summary>
public partial record Percentage : SecuritiesTransactionPrice19Choice_
{
    public required IsoPercentageRate Value { get; init; }
}

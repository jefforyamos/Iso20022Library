﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Decimal.  ISO2002 ID# _wWf3kMgqEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice18Choice;

/// <summary>
/// Indicates that price is expressed as a decimal.
/// </summary>
public partial record Decimal : ISecuritiesTransactionPrice18Choice
{
    public required IsoBaseOneRate Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BasisPoints.  ISO2002 ID# _-NZycMgpEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice18Choice;

/// <summary>
/// Used to express differences in interest rates, for example, a difference of 0.10% is equivalent to a change of 10 basis points.
/// </summary>
public partial record BasisPoints : SecuritiesTransactionPrice18Choice_
{
    public required IsoDecimalNumber Value { get; init; }
}

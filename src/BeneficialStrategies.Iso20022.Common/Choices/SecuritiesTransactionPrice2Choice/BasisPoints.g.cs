﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for BasisPoints.  ISO2002 ID# _0ng5oIbCEeWW6qdkesUKSQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice2Choice;

/// <summary>
/// Price expressed as basis points.
/// </summary>
public partial record BasisPoints : ISecuritiesTransactionPrice2Choice
{
    public required IsoDecimalNumber Value { get; init; }
}

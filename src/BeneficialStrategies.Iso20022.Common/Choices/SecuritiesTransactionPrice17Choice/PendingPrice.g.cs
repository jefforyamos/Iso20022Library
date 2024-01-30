﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingPrice.  ISO2002 ID# _gSTIi5jcEeqkLZLH6DK3UQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice17Choice;

/// <summary>
/// Indicates that price is currently not available, but pending.
/// </summary>
public partial record PendingPrice : ISecuritiesTransactionPrice17Choice
{
    public required PriceStatus1Code Value { get; init; }
}

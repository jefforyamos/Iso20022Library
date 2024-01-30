﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for PendingPrice.  ISO2002 ID# _4XpDgMgqEeuGrNSsxk3B0A.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice19Choice;

/// <summary>
/// Indicates that price is currently not available, but pending.
/// </summary>
public partial record PendingPrice : ISecuritiesTransactionPrice19Choice
{
    public required PriceStatus1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _P2iDk0c9EeaBWtcfqEyXyw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TradeTransactionCondition8Choice;

/// <summary>
/// Trade condition expressed as a code.
/// </summary>
public partial record Code : ITradeTransactionCondition8Choice
{
    public required TradeTransactionCondition5Code Value { get; init; }
}

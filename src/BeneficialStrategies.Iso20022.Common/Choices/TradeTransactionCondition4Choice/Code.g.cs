﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _AcingNokEeC60axPepSq7g_-1258318149.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeTransactionCondition4Choice;

/// <summary>
/// Trade conditions expressed in a coded form as published in an external list.
/// </summary>
public partial record Code : ITradeTransactionCondition4Choice
{
    public required ExternalTradeTransactionCondition1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _XQEckeLaEeWFtOV72FbX9w.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeTransactionCondition7Choice;

/// <summary>
/// Trade transaction condition expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ITradeTransactionCondition7Choice
{
    public required TradeTransactionCondition2Code Value { get; init; }
}

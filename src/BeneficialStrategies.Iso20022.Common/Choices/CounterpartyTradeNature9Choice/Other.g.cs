﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Other.  ISO2002 ID# _iAf0Rz7KEeq0cMLnAmm7Lg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature9Choice;

/// <summary>
/// Indicates that reporting party is other type of counterparty.
/// </summary>
public partial record Other : ICounterpartyTradeNature9Choice
{
    public required NoReasonCode Value { get; init; }
}

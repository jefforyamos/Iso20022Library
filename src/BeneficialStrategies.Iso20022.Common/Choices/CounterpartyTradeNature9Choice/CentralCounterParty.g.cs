﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CentralCounterParty.  ISO2002 ID# _iAf0RT7KEeq0cMLnAmm7Lg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature9Choice;

/// <summary>
/// Indicates that reporting party is a central counterparty.
/// </summary>
public partial record CentralCounterParty : CounterpartyTradeNature9Choice_
{
    public required NoReasonCode Value { get; init; }
}

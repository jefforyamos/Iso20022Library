﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _ALITkMGyEeivTd4NUfCi2g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradingPartyCapacity5Choice;

/// <summary>
/// Specifies the role of the party in the transaction expressed as a code.
/// </summary>
public partial record Code : ITradingPartyCapacity5Choice
{
    public required TradingCapacity7Code Value { get; init; }
}

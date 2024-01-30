﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Identification.  ISO2002 ID# _GMbzgZ3CEeuwmdq0KtnICg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentAttributes4Choice;

/// <summary>
/// Identification of a financial instrument admitted to trading.
/// </summary>
public partial record Identification : IFinancialInstrumentAttributes4Choice
{
    public required IsoISIN2021Identifier Value { get; init; }
}

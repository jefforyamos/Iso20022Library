﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CommonIdentification.  ISO2002 ID# _2ThUszt4EeW638lNyHKv7A.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References46Choice;

/// <summary>
/// Unique reference agreed upon by the two trade counterparties to identify the trade.
/// </summary>
public partial record CommonIdentification : References46Choice_
{
    public required IsoMax35Text Value { get; init; }
}

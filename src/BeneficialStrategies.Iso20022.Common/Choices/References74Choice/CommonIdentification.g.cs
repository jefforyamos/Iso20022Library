﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for CommonIdentification.  ISO2002 ID# _SiFNoSgaEey2k_sfZmJz4g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References74Choice;

/// <summary>
/// Unique reference agreed upon by the two trade counterparties to identify the trade.
/// </summary>
public partial record CommonIdentification : IReferences74Choice
{
    public required IsoMax35Text Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Proprietary.  ISO2002 ID# _POd7AMkcEeeiAIB1i4AlQw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesLendingType3Choice;

/// <summary>
/// Name of the identification scheme, in a free text form.
/// </summary>
public partial record Proprietary : ISecuritiesLendingType3Choice
{
    public required IsoMax35Text Value { get; init; }
}

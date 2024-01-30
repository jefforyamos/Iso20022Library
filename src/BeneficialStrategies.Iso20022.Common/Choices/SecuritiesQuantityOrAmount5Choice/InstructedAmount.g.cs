﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for InstructedAmount.  ISO2002 ID# _qY_3rffREeiNZp_PtLohLw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesQuantityOrAmount5Choice;

/// <summary>
/// Cash amount to be instructed.
/// </summary>
public partial record InstructedAmount : ISecuritiesQuantityOrAmount5Choice
{
    public required IsoRestrictedFINActiveCurrencyAndAmount Value { get; init; }
}

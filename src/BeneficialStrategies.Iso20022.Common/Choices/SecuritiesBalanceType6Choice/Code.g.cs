﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _q5Z-oTnsEeWfSKvvZlhRKg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesBalanceType6Choice;

/// <summary>
/// Sub-balance expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ISecuritiesBalanceType6Choice
{
    public required SecuritiesBalanceType11Code Value { get; init; }
}

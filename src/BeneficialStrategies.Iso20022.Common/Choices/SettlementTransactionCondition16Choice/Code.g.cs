﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _Q8-VwzqEEeWVrPy0StzzSg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition16Choice;

/// <summary>
/// Settlement conditions expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ISettlementTransactionCondition16Choice
{
    public required SettlementTransactionCondition10Code Value { get; init; }
}

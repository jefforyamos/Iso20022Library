﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _OOM7UwzXEeuUZuaHWzkTew.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition33Choice;

/// <summary>
/// Settlement conditions expressed as an ISO 20022 code.
/// </summary>
public partial record Code : SettlementTransactionCondition33Choice_
{
    public required SettlementTransactionCondition14Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _6IdOqZNLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition26Choice;

/// <summary>
/// Settlement conditions expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ISettlementTransactionCondition26Choice
{
    public required SettlementTransactionCondition4Code Value { get; init; }
}

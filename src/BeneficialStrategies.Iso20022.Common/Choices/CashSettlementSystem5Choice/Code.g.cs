﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _5m6BB5NLEeWGlc8L7oPDIg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashSettlementSystem5Choice;

/// <summary>
/// Cash settlement system expressed as an ISO 20022 code.
/// </summary>
public partial record Code : ICashSettlementSystem5Choice
{
    public required CashSettlementSystem2Code Value { get; init; }
}

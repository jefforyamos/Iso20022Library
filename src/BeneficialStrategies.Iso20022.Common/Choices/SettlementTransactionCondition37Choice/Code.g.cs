﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _38PHkyAaEeu4a6pNulzZ4Q.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition37Choice;

/// <summary>
/// Settlement conditions expressed as an ISO 20022 code.
/// </summary>
public partial record Code : SettlementTransactionCondition37Choice_
{
    public required SettlementTransactionCondition12Code Value { get; init; }
}

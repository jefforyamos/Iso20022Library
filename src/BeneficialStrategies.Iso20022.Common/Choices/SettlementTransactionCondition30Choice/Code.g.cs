﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _1wpf00c8EeaBWtcfqEyXyw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementTransactionCondition30Choice;

/// <summary>
/// Settlement condition expressed as a code.
/// </summary>
public partial record Code : SettlementTransactionCondition30Choice_
{
    public required SettlementTransactionCondition11Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _NW5nQTqFEemJ3KLLPeYl6g.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CashBalanceType3Choice;

/// <summary>
/// Cash balance expressed in a coded form.
/// </summary>
public partial record Code : CashBalanceType3Choice_
{
    public required ExternalBalanceType1Code Value { get; init; }
}

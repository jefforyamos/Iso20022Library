﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _NW5nQTqFEemJ3KLLPeYl6g.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.CashBalanceType3Choice;

/// <summary>
/// Cash balance expressed in a coded form.
/// </summary>
public partial record Code : ICashBalanceType3Choice
{
    public required ExternalBalanceType1Code Value { get; init; }
}

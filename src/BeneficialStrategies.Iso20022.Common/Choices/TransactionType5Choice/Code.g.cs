﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Code.  ISO2002 ID# _yS8cgVsJEea4y99eritluQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransactionType5Choice;

/// <summary>
/// Transaction type expressed as a code.
/// </summary>
public partial record Code : TransactionType5Choice_
{
    public required InvestmentFundTransactionType1Code Value { get; init; }
}

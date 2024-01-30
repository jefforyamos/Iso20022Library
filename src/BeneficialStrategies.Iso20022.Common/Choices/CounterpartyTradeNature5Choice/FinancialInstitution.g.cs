﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for FinancialInstitution.  ISO2002 ID# _97ZDEbsAEea-m5tPqiasmQ.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyTradeNature5Choice;

/// <summary>
/// Indicates that reporting counterparty is a financial institution.
/// </summary>
public partial record FinancialInstitution : ICounterpartyTradeNature5Choice
{
    public required FinancialPartySectorType1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _FAmvkcESEea7jLfvGi1PDw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ForeignExchangeSwap3Choice;

/// <summary>
/// Provides the reason why no transactions are being reported for a money market reporting period.
/// </summary>
public partial record DataSetAction : ForeignExchangeSwap3Choice_
{
    public required ReportPeriodActivity3Code Value { get; init; }
}

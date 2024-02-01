﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _9tfhFDOYEeqBfed1bmSPqg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SettlementFailsDailyTransactionType1Choice;

/// <summary>
/// Where no transaction was concluded, this field should be set so that a valid transaction data file can be submitted to the regulator as per submission requirements.
/// </summary>
public partial record DataSetAction : SettlementFailsDailyTransactionType1Choice_
{
    public required ReportPeriodActivity1Code Value { get; init; }
}

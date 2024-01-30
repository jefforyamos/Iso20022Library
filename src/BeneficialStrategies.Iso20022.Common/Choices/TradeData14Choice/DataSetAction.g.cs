﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _CpO6Yf_oEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.TradeData14Choice;

/// <summary>
/// Where no transaction was concluded, this field should be set so that a valid transaction data file can be submitted to ESMA as per daily submission requirements.
/// </summary>
public partial record DataSetAction : ITradeData14Choice
{
    public required ReportPeriodActivity1Code Value { get; init; }
}

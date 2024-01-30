﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _BO3n8a4UEemB_csI4yyKLA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData11Choice;

/// <summary>
/// Where no transaction was concluded, this field should be set so that a valid transaction data file can be submitted to ESMA as per daily submission requirements.
/// </summary>
public partial record DataSetAction : ITradeData11Choice
{
    public required ReportPeriodActivity1Code Value { get; init; }
}

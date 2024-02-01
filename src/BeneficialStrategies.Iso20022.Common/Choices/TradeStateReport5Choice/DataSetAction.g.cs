﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _x-2JIcK-EeuCIrYISEfoUg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeStateReport5Choice;

/// <summary>
/// Where no transaction was concluded, this field should be set so that a valid trade data file can be submitted to ESMA as per daily submission requirements.
/// </summary>
public partial record DataSetAction : TradeStateReport5Choice_
{
    public required ReportPeriodActivity1Code Value { get; init; }
}

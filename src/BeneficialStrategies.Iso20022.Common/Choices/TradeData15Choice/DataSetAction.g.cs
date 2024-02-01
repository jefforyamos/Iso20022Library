﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _34vr8f_qEemm3skPVSMJQg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData15Choice;

/// <summary>
/// Where no transaction was concluded, this field should be set so that a valid transaction data file can be submitted to ESMA as per daily submission requirements.
/// </summary>
public partial record DataSetAction : TradeData15Choice_
{
    public required ReportPeriodActivity1Code Value { get; init; }
}

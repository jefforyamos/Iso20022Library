﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _oyOywVosEe23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeData55Choice;

/// <summary>
/// Where no reporting data are available, this field should be set so that a valid reference data file can be submitted to the competent authority as per submission requirements.
/// </summary>
public partial record DataSetAction : TradeData55Choice_
{
    public required ReportPeriodActivity1Code Value { get; init; }
}

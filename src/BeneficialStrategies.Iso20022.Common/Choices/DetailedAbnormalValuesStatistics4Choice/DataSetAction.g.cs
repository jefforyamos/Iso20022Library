﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _x4ww4VyGEe24CqbZJK5XxA.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DetailedAbnormalValuesStatistics4Choice;

/// <summary>
/// Specifies the type of report activity for a specific reporting period.
/// </summary>
public partial record DataSetAction : DetailedAbnormalValuesStatistics4Choice_
{
    public required ReportPeriodActivity1Code Value { get; init; }
}

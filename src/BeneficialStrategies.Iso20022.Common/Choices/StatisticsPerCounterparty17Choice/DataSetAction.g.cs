﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for DataSetAction.  ISO2002 ID# _x82msVyGEe24CqbZJK5XxA.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty17Choice;

/// <summary>
/// Where no reporting data are available, this field should be set so that a valid reference data file can be submitted to the competent authority as per submission requirements.
/// </summary>
public partial record DataSetAction : IStatisticsPerCounterparty17Choice
{
    public required ReportPeriodActivity1Code Value { get; init; }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _85s8lEwWEeqwfMIOLcNxbw.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty2Choice;

/// <summary>
/// Detailed statistics per counterparty.
/// </summary>
public partial record Report : IStatisticsPerCounterparty2Choice
{
    #nullable enable
    /// <summary>
    /// Reference period for statistics collection.
    /// </summary>
    public required Period2 ReportingPeriod { get; init; } 
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    public required CounterpartyData36 CounterpartyIdentification { get; init; } 
    /// <summary>
    /// Detailed information on rejections for derivatives submitted to trade repositories and failed to pass validations.
    /// </summary>
    public required RejectionStatistics3 RejectionStatistics { get; init; } 
    /// <summary>
    /// Identification of the competent authority which supervises the reporting counterparty.
    /// </summary>
    public CompetentAuthority1? CompetentAuthority { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}

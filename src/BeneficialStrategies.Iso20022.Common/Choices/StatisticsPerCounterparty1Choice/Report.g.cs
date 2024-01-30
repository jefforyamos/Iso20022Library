﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _98o1t0wVEeqwfMIOLcNxbw.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty1Choice;

/// <summary>
/// Detailed statistics per counterparty.
/// </summary>
public partial record Report : IStatisticsPerCounterparty1Choice
{
    #nullable enable
    /// <summary>
    /// Reference date for statistics collection.
    /// </summary>
    public required IsoISODate ReferenceDate { get; init; } 
    /// <summary>
    /// Data specific to counterparties and related fields.
    /// </summary>
    public required TradeCounterpartyReport9 CounterpartyIdentification { get; init; } 
    /// <summary>
    /// Detailed information on derivatives submitted for reconciliation.
    /// </summary>
    public required ReconciliationStatisticsPerDerivativeContractGroup3 ReconciliationStatistics { get; init; } 
    /// <summary>
    /// Identification of the competent authority which supervises the reporting counterparty.
    /// </summary>
    public CompetentAuthority1? CompetentAuthority { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}

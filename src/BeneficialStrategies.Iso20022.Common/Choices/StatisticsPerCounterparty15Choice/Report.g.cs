﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _cFghI1ovEe23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty15Choice;

/// <summary>
/// Detailed statistics per counterparty.
/// </summary>
public partial record Report : IStatisticsPerCounterparty15Choice
{
    #nullable enable
    /// <summary>
    /// Reference date for statistics collection.
    /// </summary>
    public required IsoISODate ReferenceDate { get; init; } 
    /// <summary>
    /// Different categories of statuses for a derivative.
    /// </summary>
    public required IReportingRequirement2Choice ReconciliationCategories { get; init; } 
    /// <summary>
    /// Number of all reports per status on derivatives submitted for reconciliation.
    /// </summary>
    public IsoNumber? TotalNumberOfTransactions { get; init; } 
    /// <summary>
    /// Details of derivatives submitted for reconciliation per counterparty pair.
    /// </summary>
    public ReconciliationCounterpartyPairStatistics6? TransactionDetails { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}

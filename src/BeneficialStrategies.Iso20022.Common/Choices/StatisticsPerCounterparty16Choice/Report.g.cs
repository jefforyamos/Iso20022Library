﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _rpsLQ1owEe23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.StatisticsPerCounterparty16Choice;

/// <summary>
/// Detailed information on statistics per combination of counterparties.
/// </summary>
public partial record Report : IStatisticsPerCounterparty16Choice
{
    #nullable enable
    /// <summary>
    /// Reference date for statistics collection.
    /// </summary>
    public required IsoISODate ReferenceDate { get; init; } 
    /// <summary>
    /// Detailed information of outstanding derivatives for which the valuation was not reported or the valuation reported is more than fourteen calendar days earlier than the date for which the report was generated shall be included in the report of missing valuations at the end of the day.
    /// </summary>
    public required IDetailedMissingValuationsStatistics4Choice MissingValuation { get; init; } 
    /// <summary>
    /// Detailed information of the outstanding derivatives for which no margin information has been reported, or the margin information that was reported is dated more than fourteen calendar days earlier than the day.
    /// </summary>
    public required IDetailedMissingMarginInformationStatistics4Choice MissingMarginInformation { get; init; } 
    /// <summary>
    /// Detailed information of the derivatives that were received on the day of generation of the report with action type ‘New’, ‘Position component’, ‘Modification’ or ‘Correction’ whose notional amount is greater than a threshold for that class of derivatives.
    /// </summary>
    public required IDetailedAbnormalValuesStatistics4Choice AbnormalValues { get; init; } 
    #nullable disable
}

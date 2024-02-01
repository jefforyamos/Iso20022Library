﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ConcreteChoiceGenerator for Report.  ISO2002 ID# _rsDiw1owEe23K4GXSpBSeg.
//

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DetailedMissingMarginInformationStatistics4Choice;

/// <summary>
/// Detailed information on statistics per combination of counterparties.
/// </summary>
public partial record Report : DetailedMissingMarginInformationStatistics4Choice_
{
    #nullable enable
    /// <summary>
    /// Number of outstanding derivatives. 
    /// </summary>
    public required IsoNumber NumberOfOutstandingDerivatives { get; init; } 
    /// <summary>
    /// Number of outstanding derivatives with no margin information.
    /// </summary>
    public required IsoNumber NumberOfOutstandingDerivativesWithNoMarginInformation { get; init; } 
    /// <summary>
    /// Number of outstanding derivatives with outdated margin information.
    /// </summary>
    public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedMarginInformation { get; init; } 
    /// <summary>
    /// Details of the outstanding derivatives for which no margin information has been reported, or the margin information that was reported is dated more than fourteen calendar days earlier than the day.
    /// </summary>
    public MissingMarginData2? Warnings { get; init;  } // Warning: Don't know multiplicity.
    #nullable disable
}

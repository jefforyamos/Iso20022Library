﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for DetailedTransactionStatistics27.  ISO2002 ID# _x1GY5VyGEe24CqbZJK5XxA.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about outstanding derivatives, outstanding derivatives with no valuation and outstanding derivatives with outdated valuation.
/// </summary>
public partial record DetailedTransactionStatistics27
{
    #nullable enable
    
    /// <summary>
    /// Number of outstanding derivatives. 
    /// </summary>
    public required IsoNumber NumberOfOutstandingDerivatives { get; init; } 
    /// <summary>
    /// Number of outstanding derivatives for which valuation amount was never reported.
    /// </summary>
    public required IsoNumber NumberOfOutstandingDerivativesWithNoValuation { get; init; } 
    /// <summary>
    /// Number of outstanding derivatives with outdated valuation.
    /// </summary>
    public required IsoNumber NumberOfOutstandingDerivativesWithOutdatedValuation { get; init; } 
    /// <summary>
    /// Details of outstanding derivatives for which the valuation was not reported or the valuation reported is more than fourteen calendar days earlier than the date for which the report was generated shall be included in the report of missing valuations at the end of the day.
    /// </summary>
    public MissingValuationsData2? Warnings { get; init;  } // Warning: Don't know multiplicity.
    
    #nullable disable
}

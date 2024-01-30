﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for YieldCalculation7.  ISO2002 ID# _eFO8kQeCEe2fOITqoTnSLQ.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return provided by a financial instrument.
/// </summary>
public partial record YieldCalculation7
{
    #nullable enable
    
    /// <summary>
    /// Result of the yield calculation.
    /// </summary>
    public required IsoPercentageRate Value { get; init; } 
    /// <summary>
    /// Specifies the type of calculation.
    /// </summary>
    public required CalculationType1Code CalculationType { get; init; } 
    /// <summary>
    /// Price to which the yield has been calculated.
    /// </summary>
    public Price14? RedemptionPrice { get; init; } 
    /// <summary>
    /// Date/time on which the calculation is based, for example, valuation on October 1 (price date) based on price of September 19 ( value date).
    /// </summary>
    public IsoISODate? ValueDate { get; init; } 
    /// <summary>
    /// Period on which the calculation is based.
    /// </summary>
    public IDateTimePeriod1Choice? ValuePeriod { get; init; } 
    /// <summary>
    /// Included as needed to clarify yield irregularities associated with date, e.g. when it falls on a non-business day.
    /// </summary>
    public IsoISODate? CalculationDate { get; init; } 
    
    #nullable disable
}

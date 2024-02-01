﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for YieldCalculation6.  ISO2002 ID# _1qNR4Wp7EemmaZLSPtWX5A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Return provided by a financial instrument.
/// </summary>
public partial record YieldCalculation6
{
    #nullable enable
    
    /// <summary>
    /// Result of the yield calculation.
    /// </summary>
    public required IsoPercentageRate Value { get; init; } 
    /// <summary>
    /// Specifies the type of calculation.
    /// </summary>
    public CalculationType3Choice_? CalculationType { get; init; } 
    /// <summary>
    /// Price to which the yield has been calculated.
    /// </summary>
    public Price8? RedemptionPrice { get; init; } 
    /// <summary>
    /// Date/time on which the calculation is based, for example, valuation on October 1 (price date) based on price of September 19 ( value date).
    /// </summary>
    public required IsoISODate ValueDate { get; init; } 
    /// <summary>
    /// Period on which the calculation is based.
    /// </summary>
    public required DateTimePeriod1Choice_ ValuePeriod { get; init; } 
    /// <summary>
    /// Clarifies yield irregularities associated with date, for example when it falls on a non-business day.
    /// </summary>
    public required IsoISODateTime CalculationDate { get; init; } 
    
    #nullable disable
}

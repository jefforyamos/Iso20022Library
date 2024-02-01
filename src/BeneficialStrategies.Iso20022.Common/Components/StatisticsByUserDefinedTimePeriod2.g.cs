﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for StatisticsByUserDefinedTimePeriod2.  ISO2002 ID# _Se4bTNp-Ed-ak6NoX_4Aeg_1006320598.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statistical data related to the price change of a security.
/// </summary>
public partial record StatisticsByUserDefinedTimePeriod2
{
    #nullable enable
    
    /// <summary>
    /// Reference period for the valuation.
    /// </summary>
    public required DateOrDateTimePeriodChoice_ Period { get; init; } 
    /// <summary>
    /// Highest price for the referenced period.
    /// </summary>
    public PriceValue5? HighestPriceValue { get; init; } 
    /// <summary>
    /// Lowest price for the referenced period.
    /// </summary>
    public PriceValue5? LowestPriceValue { get; init; } 
    /// <summary>
    /// Change in price since the previous valuation date.
    /// </summary>
    public PriceValueChange1? PriceChange { get; init; } 
    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    public IsoPercentageRate? Yield { get; init; } 
    
    #nullable disable
}

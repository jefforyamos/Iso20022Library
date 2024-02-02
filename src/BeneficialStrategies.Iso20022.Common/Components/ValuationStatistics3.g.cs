﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ValuationStatistics3.  ISO2002 ID# _SeuqT9p-Ed-ak6NoX_4Aeg_578731261.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Statistical data related to the price change of a security.
/// </summary>
[DataContract]
[XmlType]
public partial record ValuationStatistics3
{
    #nullable enable
    
    /// <summary>
    /// Currency of the valuation statistics.
    /// </summary>
    [DataMember]
    public required ActiveOrHistoricCurrencyCode Currency { get; init; } 
    /// <summary>
    /// Type of price from which the change is calculated, eg, bid, offer, or single.
    /// </summary>
    [DataMember]
    public required PriceType2 PriceTypeChangeBasis { get; init; } 
    /// <summary>
    /// Change in price since the previous valuation date.
    /// </summary>
    [DataMember]
    public required PriceValueChange1 PriceChange { get; init; } 
    /// <summary>
    /// Rate of income from the financial instrument, usually calculated as total dividends or coupon interest available to investors in the last year,divided by the current price.
    /// </summary>
    [DataMember]
    public IsoPercentageRate? Yield { get; init; } 
    /// <summary>
    /// Information related to price variations, expressed using pre-defined periods.
    /// </summary>
    [DataMember]
    public StatisticsByPredefinedTimePeriods2? ByPredefinedTimePeriods { get; init; } 
    /// <summary>
    /// Information related to price variations, expressed using user-defined periods.
    /// </summary>
    [DataMember]
    public ValueList<StatisticsByUserDefinedTimePeriod2> ByUserDefinedTimePeriod { get; init; } = []; // Warning: Don't know multiplicity.
    
    #nullable disable
}

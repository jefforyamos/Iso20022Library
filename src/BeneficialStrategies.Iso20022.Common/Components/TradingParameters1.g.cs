﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TradingParameters1.  ISO2002 ID# _hZpQ4GliEeGaMcKyqKNRfQ_173827975.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Place at which the security is traded.
/// </summary>
public partial record TradingParameters1
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to places of trade, ie, stock exchanges, regulated markets, for example, Electronic Trading Platforms (ECN), and unregulated markets, for example, Automated Trading Systems (ATS) (MIC - ISO 3166).
    /// </summary>
    public IsoMICIdentifier? MarketIdentification { get; init; } 
    /// <summary>
    /// Minimum quantity of securities that can be purchased without incurring a larger fee. For example, if the round lot size is 100 and the trade is for 125 shares, then 100 will be processed without a fee and the remaining 25 will incur a service fee for being an odd lot size.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? RoundLot { get; init; } 
    /// <summary>
    /// Minimum number of securities that can be traded.
    /// </summary>
    public FinancialInstrumentQuantity1Choice_? TradeLotSize { get; init; } 
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    public IsoMICIdentifier[] SecondaryPlaceOfListing { get; init; } = [];
    /// <summary>
    /// Minimum number of securities that can be traded.
    /// </summary>
    public UnitOrFaceAmountChoice_? MinimumTradedNominalQuantity { get; init; } 
    /// <summary>
    /// Maximum number of securities that can be traded.
    /// </summary>
    public UnitOrFaceAmountChoice_? MaximumTradedNominalQuantity { get; init; } 
    /// <summary>
    /// Indicates the minimum or smallest movement (up or down) in the price allowed for the security.
    /// </summary>
    public IsoNumber? MinimumTradingPricingIncrement { get; init; } 
    /// <summary>
    /// Market(s) on which the security is listed.
    /// </summary>
    public IsoMICIdentifier? PrimaryPlaceOfListingIdentification { get; init; } 
    
    #nullable disable
}

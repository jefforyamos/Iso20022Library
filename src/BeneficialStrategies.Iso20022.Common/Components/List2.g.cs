﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for List2.  ISO2002 ID# _SzmHAtp-Ed-ak6NoX_4Aeg_-606838649.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides the details for negotiating and trading a large number of securities contained in or comprising a portfolio. ||One example is index arbitrage, which consists in the purchase or sale of a basket of stocks in conjunction with the sale or purchase of|a derivative product (for example index futures) to profit from price differences between the basket and the derivative product. ||Other examples include liquidation of EFP (Exchange for Physical) stock positions, portfolio realignment and portfolio liquidation.
/// </summary>
public partial record List2
{
    #nullable enable
    
    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party. The identifier must be unique within a single trading day.
    /// </summary>
    public required IsoMax35Text ListIdentification { get; init; } 
    /// <summary>
    /// Indicates the date and time of the agreement in principal between counter-parties prior to actual trade date.|Used with fixed income for municipal new issue markets.
    /// </summary>
    public IsoISODateTime? TradeOriginationDateTime { get; init; } 
    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    public IsoISODateTime? TradeDate { get; init; } 
    
    #nullable disable
}

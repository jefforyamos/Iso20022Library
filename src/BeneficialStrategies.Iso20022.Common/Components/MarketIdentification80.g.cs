﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarketIdentification80.  ISO2002 ID# _0PQZ0TAdEeOdVfle5cojCg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
public partial record MarketIdentification80
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to places of trade, ie, stock exchanges, regulated markets, eg, Electronic Trading Platforms (ECN), and unregulated markets, eg, Automated Trading Systems (ATS), as sources of prices and related information, in order to facilitate automated processing.
    /// </summary>
    public IMarketIdentification3Choice? Identification { get; init; } 
    /// <summary>
    /// Nature of a market in which transactions take place.
    /// </summary>
    public IMarketType12Choice? Type { get; init; } 
    
    #nullable disable
}

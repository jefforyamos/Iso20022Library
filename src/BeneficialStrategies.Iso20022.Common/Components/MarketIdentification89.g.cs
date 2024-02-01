﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarketIdentification89.  ISO2002 ID# _Ikx50TnWEeWV5sr121Fc8A.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
public partial record MarketIdentification89
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to places of trade (stock exchanges), to regulated markets (for example, Electronic Trading Platforms - ECN), and to unregulated markets (for example, Automated Trading Systems - ATS), as sources of prices and related information, in order to facilitate automated processing.
    /// </summary>
    public MarketIdentification1Choice_? Identification { get; init; } 
    /// <summary>
    /// Nature of a market in which transactions take place.
    /// </summary>
    public required MarketType15Choice_ Type { get; init; } 
    
    #nullable disable
}

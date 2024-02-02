﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarketIdentification90.  ISO2002 ID# _cj_VOZKQEeWHWpTQn1FFVg.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
[DataContract]
[XmlType]
public partial record MarketIdentification90
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to places of trade, that is, stock exchanges, regulated markets, for example, Electronic Trading Platforms (ECN), and unregulated markets, for example, Automated Trading Systems (ATS), as sources of prices and related information, in order to facilitate automated processing.
    /// </summary>
    [DataMember]
    public MarketIdentification2Choice_? Identification { get; init; } 
    /// <summary>
    /// Nature of a market in which transactions take place.
    /// </summary>
    [DataMember]
    public required MarketType16Choice_ Type { get; init; } 
    
    #nullable disable
}

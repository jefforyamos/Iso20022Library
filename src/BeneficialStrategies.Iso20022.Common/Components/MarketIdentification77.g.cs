﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MarketIdentification77.  ISO2002 ID# _ArcmOtokEeC60axPepSq7g_1234584716.
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
public partial record MarketIdentification77
{
    #nullable enable
    
    /// <summary>
    /// Code allocated to places of trade, ie, stock exchanges, regulated markets, eg, Electronic Trading Platforms (ECN), and unregulated markets, eg, Automated Trading Systems (ATS), as sources of prices and related information, in order to facilitate automated processing.
    /// </summary>
    [DataMember]
    public MarketIdentification3Choice_? Identification { get; init; } 
    /// <summary>
    /// Nature of a market in which transactions take place.
    /// </summary>
    [DataMember]
    public MarketType11Choice_? Type { get; init; } 
    
    #nullable disable
}

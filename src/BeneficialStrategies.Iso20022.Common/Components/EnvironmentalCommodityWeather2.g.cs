﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnvironmentalCommodityWeather2.  ISO2002 ID# _Dqy6gU8SEe2PGo0mhYCh1g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of an environmental derivative of type weather.
/// </summary>
[DataContract]
[XmlType]
public partial record EnvironmentalCommodityWeather2
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [DataMember]
    public required AssetClassProductType3Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [DataMember]
    public AssetClassSubProductType30Code? SubProduct { get; init; } 
    
    #nullable disable
}

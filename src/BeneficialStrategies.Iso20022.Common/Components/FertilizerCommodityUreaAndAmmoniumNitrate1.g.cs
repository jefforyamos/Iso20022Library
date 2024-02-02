﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for FertilizerCommodityUreaAndAmmoniumNitrate1.  ISO2002 ID# _f4Fn8Fr2EeWN79Bl6BUd3g.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of a fertilizer derivative of type urea and ammonium nitrate.
/// </summary>
[DataContract]
[XmlType]
public partial record FertilizerCommodityUreaAndAmmoniumNitrate1
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [DataMember]
    public required AssetClassProductType5Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [DataMember]
    public required AssetClassSubProductType44Code SubProduct { get; init; } 
    
    #nullable disable
}

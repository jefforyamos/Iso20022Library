﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MetalCommodityPrecious1.  ISO2002 ID# _ZEBqZA2rEeW72qLtWESimw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of a metal derivative of type precious.
/// </summary>
[DataContract]
[XmlType]
public partial record MetalCommodityPrecious1
{
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [DataMember]
    public required AssetClassProductType7Code BaseProduct { get; init; } 
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [DataMember]
    public required AssetClassSubProductType16Code SubProduct { get; init; } 
    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    [DataMember]
    public required AssetClassDetailedSubProductType11Code AdditionalSubProduct { get; init; } 
    
    #nullable disable
}

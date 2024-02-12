﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for MetalCommodityPrecious1.  ISO2002 ID# _ZEBqZA2rEeW72qLtWESimw.
//

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Defines commodity sub-product attributes of a metal derivative of type precious.
/// </summary>
[IsoId("_ZEBqZA2rEeW72qLtWESimw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Metal Commodity Precious")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record MetalCommodityPrecious1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a MetalCommodityPrecious1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public MetalCommodityPrecious1( AssetClassProductType7Code reqBaseProduct,AssetClassSubProductType16Code reqSubProduct,AssetClassDetailedSubProductType11Code reqAdditionalSubProduct )
    {
        BaseProduct = reqBaseProduct;
        SubProduct = reqSubProduct;
        AdditionalSubProduct = reqAdditionalSubProduct;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_ZEBqZQ2rEeW72qLtWESimw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Base Product")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassProductType7Code BaseProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AssetClassProductType7Code BaseProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassProductType7Code BaseProduct { get; init; } 
    #else
    public AssetClassProductType7Code BaseProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_ZEBqZw2rEeW72qLtWESimw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sub Product")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassSubProductType16Code SubProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AssetClassSubProductType16Code SubProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassSubProductType16Code SubProduct { get; init; } 
    #else
    public AssetClassSubProductType16Code SubProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Further subproduct type related to instruments that have a non-financial instrument or commodity as underlying.
    /// </summary>
    [IsoId("_ZEBqZg2rEeW72qLtWESimw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Sub Product")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassDetailedSubProductType11Code AdditionalSubProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AssetClassDetailedSubProductType11Code AdditionalSubProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassDetailedSubProductType11Code AdditionalSubProduct { get; init; } 
    #else
    public AssetClassDetailedSubProductType11Code AdditionalSubProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}

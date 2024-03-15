﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AgriculturalCommodityOther1.  ISO2002 ID# _DtvYMLvfEeiLRYqS-r-R-A.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Other agricultural commodity derivative.
/// </summary>
[IsoId("_DtvYMLvfEeiLRYqS-r-R-A")]
[DisplayName("Agricultural Commodity Other")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AgriculturalCommodityOther1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a AgriculturalCommodityOther1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public AgriculturalCommodityOther1( AssetClassProductType1Code reqBaseProduct,AssetClassSubProductType49Code reqSubProduct )
    {
        BaseProduct = reqBaseProduct;
        SubProduct = reqSubProduct;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_sAg4cLvfEeiLRYqS-r-R-A")]
    [DisplayName("Base Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="BasePdct")]
    #endif
    [IsoXmlTag("BasePdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassProductType1Code BaseProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AssetClassProductType1Code BaseProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassProductType1Code BaseProduct { get; init; } 
    #else
    public AssetClassProductType1Code BaseProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_zqC1oLvfEeiLRYqS-r-R-A")]
    [DisplayName("Sub Product")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubPdct")]
    #endif
    [IsoXmlTag("SubPdct")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassSubProductType49Code SubProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AssetClassSubProductType49Code SubProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassSubProductType49Code SubProduct { get; init; } 
    #else
    public AssetClassSubProductType49Code SubProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}

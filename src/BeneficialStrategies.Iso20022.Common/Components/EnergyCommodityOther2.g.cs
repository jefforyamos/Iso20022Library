﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for EnergyCommodityOther2.  ISO2002 ID# _sHZFIU8SEe2PGo0mhYCh1g.
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
/// Other energy commodity derivative.
/// </summary>
[IsoId("_sHZFIU8SEe2PGo0mhYCh1g")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Energy Commodity Other")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EnergyCommodityOther2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a EnergyCommodityOther2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public EnergyCommodityOther2( AssetClassProductType2Code reqBaseProduct )
    {
        BaseProduct = reqBaseProduct;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Base product for the underlying asset class as specified in the classification of commodities derivatives table.
    /// </summary>
    [IsoId("_sIQAwU8SEe2PGo0mhYCh1g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Base Product")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AssetClassProductType2Code BaseProduct { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AssetClassProductType2Code BaseProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassProductType2Code BaseProduct { get; init; } 
    #else
    public AssetClassProductType2Code BaseProduct { get; set; } 
    #endif
    
    /// <summary>
    /// Sub-product for the underlying asset class.
    /// </summary>
    [IsoId("_sIQAw08SEe2PGo0mhYCh1g")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sub Product")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassSubProductType49Code? SubProduct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassSubProductType49Code? SubProduct { get; init; } 
    #else
    public AssetClassSubProductType49Code? SubProduct { get; set; } 
    #endif
    
    
    #nullable disable
    
}

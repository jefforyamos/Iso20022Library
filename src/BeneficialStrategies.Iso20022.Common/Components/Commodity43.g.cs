﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Commodity43.  ISO2002 ID# _X74TEcg7EeuWwaMSwXJLEA.
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
/// Data specific to commodities and related informations used as a collateral.
/// </summary>
[IsoId("_X74TEcg7EeuWwaMSwXJLEA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Commodity")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Commodity43
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Details on commodities assignments to sectors.
    /// </summary>
    [IsoId("_X-T8A8g7EeuWwaMSwXJLEA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Classification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AssetClassCommodity5Choice_? Classification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AssetClassCommodity5Choice_? Classification { get; init; } 
    #else
    public AssetClassCommodity5Choice_? Classification { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of the commodity.
    /// </summary>
    [IsoId("_X-T8Bcg7EeuWwaMSwXJLEA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Quantity17? Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity17? Quantity { get; init; } 
    #else
    public Quantity17? Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Price of unit of asset or collateral component, including accrued interest for interest-bearing securities, used to value the commodity .
    /// </summary>
    [IsoId("_X-T8B8g7EeuWwaMSwXJLEA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Unit Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; init; } 
    #else
    public SecuritiesTransactionPrice19Choice_? UnitPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Market value of asset or collateral component.
    /// </summary>
    [IsoId("_X-T8Ccg7EeuWwaMSwXJLEA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Market Value")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AmountAndDirection53? MarketValue { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection53? MarketValue { get; init; } 
    #else
    public AmountAndDirection53? MarketValue { get; set; } 
    #endif
    
    
    #nullable disable
    
}

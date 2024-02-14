﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LoyaltyRebates1.  ISO2002 ID# _M2VZgNxOEeioifFt1dhnJA.
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
/// Rebate form to an award.
/// </summary>
[IsoId("_M2VZgNxOEeioifFt1dhnJA")]
[DisplayName("Loyalty Rebates")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LoyaltyRebates1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// The global awarded amount that is not attached to an item.
    /// </summary>
    [IsoId("_Wj6SENxOEeioifFt1dhnJA")]
    [DisplayName("Total Rebate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlRbt")]
    #endif
    [IsoXmlTag("TtlRbt")]
    [IsoSimpleType(IsoSimpleType.ImpliedCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? TotalRebate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalRebate { get; init; } 
    #else
    public System.Decimal? TotalRebate { get; set; } 
    #endif
    
    /// <summary>
    /// Short text to qualify a rebate on an line item.
    /// </summary>
    [IsoId("_ZewSkNxOEeioifFt1dhnJA")]
    [DisplayName("Rebate Label")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RbtLabl")]
    #endif
    [IsoXmlTag("RbtLabl")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? RebateLabel { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RebateLabel { get; init; } 
    #else
    public System.String? RebateLabel { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of the payment transaction related to the Loyalty.
    /// </summary>
    [IsoId("_dE2PgNxOEeioifFt1dhnJA")]
    [DisplayName("Sale Item Rebate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleItmRbt")]
    #endif
    [IsoXmlTag("SaleItmRbt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleItemRebate1? SaleItemRebate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleItemRebate1? SaleItemRebate { get; init; } 
    #else
    public SaleItemRebate1? SaleItemRebate { get; set; } 
    #endif
    
    
    #nullable disable
    
}

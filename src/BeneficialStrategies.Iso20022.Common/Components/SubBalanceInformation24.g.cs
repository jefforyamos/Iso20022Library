﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SubBalanceInformation24.  ISO2002 ID# _csYs0zi8Eeydid5dcNPKvg.
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
/// Net position of a segregated holding of a single security within the overall position held in the securities account, for example, sub-balance per status.
/// </summary>
[IsoId("_csYs0zi8Eeydid5dcNPKvg")]
[DisplayName("Sub Balance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SubBalanceInformation24
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SubBalanceInformation24 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SubBalanceInformation24( SubBalanceType13Choice_ reqSubBalanceType,Balance27 reqQuantity )
    {
        SubBalanceType = reqSubBalanceType;
        Quantity = reqQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reason for the sub-balance.
    /// </summary>
    [IsoId("_csYs2Ti8Eeydid5dcNPKvg")]
    [DisplayName("Sub Balance Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubBalTp")]
    #endif
    [IsoXmlTag("SubBalTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SubBalanceType13Choice_ SubBalanceType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SubBalanceType13Choice_ SubBalanceType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SubBalanceType13Choice_ SubBalanceType { get; init; } 
    #else
    public SubBalanceType13Choice_ SubBalanceType { get; set; } 
    #endif
    
    /// <summary>
    /// Quantity of securities in the sub-balance.
    /// </summary>
    [IsoId("_csYs4Ti8Eeydid5dcNPKvg")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty")]
    #endif
    [IsoXmlTag("Qty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Balance27 Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Balance27 Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Balance27 Quantity { get; init; } 
    #else
    public Balance27 Quantity { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional subbalance information.
    /// </summary>
    [IsoId("_csYs6Ti8Eeydid5dcNPKvg")]
    [DisplayName("Sub Balance Additional Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubBalAddtlDtls")]
    #endif
    [IsoXmlTag("SubBalAddtlDtls")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINXMax140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRestrictedFINXMax140Text? SubBalanceAdditionalDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? SubBalanceAdditionalDetails { get; init; } 
    #else
    public System.String? SubBalanceAdditionalDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Breakdown of the aggregate quantity reported into significant lots, for example, tax lots.
    /// </summary>
    [IsoId("_csYs8Ti8Eeydid5dcNPKvg")]
    [DisplayName("Quantity Breakdown")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyBrkdwn")]
    #endif
    [IsoXmlTag("QtyBrkdwn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public QuantityBreakdown71? QuantityBreakdown { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public QuantityBreakdown71? QuantityBreakdown { get; init; } 
    #else
    public QuantityBreakdown71? QuantityBreakdown { get; set; } 
    #endif
    
    /// <summary>
    /// Provides additional instrument sub-balance information on all or parts of the reported financial instrument (unregistered, tax exempt, etc.).
    /// </summary>
    [IsoId("_csYs-Ti8Eeydid5dcNPKvg")]
    [DisplayName("Additional Balance Breakdown Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlBalBrkdwnDtls")]
    #endif
    [IsoXmlTag("AddtlBalBrkdwnDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalBalanceInformation24? AdditionalBalanceBreakdownDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalBalanceInformation24? AdditionalBalanceBreakdownDetails { get; init; } 
    #else
    public AdditionalBalanceInformation24? AdditionalBalanceBreakdownDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionPrice68.  ISO2002 ID# _n-nV0ZbSEee8S7xwGG7Veg.
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
/// Specifies prices related to a corporate action option.
/// </summary>
[IsoId("_n-nV0ZbSEee8S7xwGG7Veg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Price")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionPrice68
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Cash disbursement in lieu of equities; usually in lieu of fractional quantity.
    /// </summary>
    [IsoId("_oPIeE5bSEee8S7xwGG7Veg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash In Lieu Of Share Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; init; } 
    #else
    public PriceFormat45Choice_? CashInLieuOfSharePrice { get; set; } 
    #endif
    
    /// <summary>
    /// Amount of money required per over-subscribed equity as defined by the issuer.
    /// </summary>
    [IsoId("_oPIeG5bSEee8S7xwGG7Veg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Over Subscription Deposit Price")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; init; } 
    #else
    public PriceFormat45Choice_? OverSubscriptionDepositPrice { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum cash amount that may be instructed.
    /// </summary>
    [IsoId("_Dn3JwJbTEee8S7xwGG7Veg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Maximum Cash To Instruct")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat61Choice_? MaximumCashToInstruct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat61Choice_? MaximumCashToInstruct { get; init; } 
    #else
    public PriceFormat61Choice_? MaximumCashToInstruct { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum cash amount that may be instructed.
    /// </summary>
    [IsoId("_LJvm0JbTEee8S7xwGG7Veg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Minimum Cash To Instruct")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat61Choice_? MinimumCashToInstruct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat61Choice_? MinimumCashToInstruct { get; init; } 
    #else
    public PriceFormat61Choice_? MinimumCashToInstruct { get; set; } 
    #endif
    
    /// <summary>
    /// Minimum multiple of a cash amount that may be instructed.
    /// </summary>
    [IsoId("_VWIiUJbTEee8S7xwGG7Veg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Minimum Multiple Cash To Instruct")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; init; } 
    #else
    public PriceFormat61Choice_? MinimumMultipleCashToInstruct { get; set; } 
    #endif
    
    
    #nullable disable
    
}

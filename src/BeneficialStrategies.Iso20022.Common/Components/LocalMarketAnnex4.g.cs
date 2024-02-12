﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for LocalMarketAnnex4.  ISO2002 ID# _YOEiQbrcEeqxc9M5o04tAA.
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
/// Context, or geographic environment, in which trading parties may meet in order to negotiate and execute trades among themselves.
/// </summary>
[IsoId("_YOEiQbrcEeqxc9M5o04tAA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Local Market Annex")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record LocalMarketAnnex4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a LocalMarketAnnex4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public LocalMarketAnnex4( OrderDesk1 reqLocalOrderDesk )
    {
        LocalOrderDesk = reqLocalOrderDesk;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Country of the local fund order desk.
    /// </summary>
    [IsoId("_YhHaE7rcEeqxc9M5o04tAA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Country")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public string? Country { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _YhHaE7rcEeqxc9M5o04tAA
    
    /// <summary>
    /// Local entity appointed by the fund, to which orders should be submitted. 
    /// </summary>
    [IsoId("_YhHaFbrcEeqxc9M5o04tAA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Local Order Desk")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OrderDesk1 LocalOrderDesk { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public OrderDesk1 LocalOrderDesk { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OrderDesk1 LocalOrderDesk { get; init; } 
    #else
    public OrderDesk1 LocalOrderDesk { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to a subscription to the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_YhHaF7rcEeqxc9M5o04tAA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Subscription Processing Characteristics")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingCharacteristics8? SubscriptionProcessingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingCharacteristics8? SubscriptionProcessingCharacteristics { get; init; } 
    #else
    public ProcessingCharacteristics8? SubscriptionProcessingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to a redemption to the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_YhHaGbrcEeqxc9M5o04tAA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Redemption Processing Characteristics")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingCharacteristics5? RedemptionProcessingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingCharacteristics5? RedemptionProcessingCharacteristics { get; init; } 
    #else
    public ProcessingCharacteristics5? RedemptionProcessingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Processing characteristics linked to a switch of the investment fund or alternative/hedge fund.
    /// </summary>
    [IsoId("_YhHaG7rcEeqxc9M5o04tAA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Switch Processing Characteristics")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; init; } 
    #else
    public ProcessingCharacteristics6? SwitchProcessingCharacteristics { get; set; } 
    #endif
    
    /// <summary>
    /// Account to be used for cash settlement.
    /// </summary>
    [IsoId("_YhHaHbrcEeqxc9M5o04tAA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Cash Settlement Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CashAccount202? CashSettlementDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CashAccount202? CashSettlementDetails { get; init; } 
    #else
    public CashAccount202? CashSettlementDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information about the fund order desk.
    /// </summary>
    [IsoId("_YhHaH7rcEeqxc9M5o04tAA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Additional Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalInformation15? AdditionalInformation { get; init; } 
    #else
    public AdditionalInformation15? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}

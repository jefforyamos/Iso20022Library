﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SplitTradeDetails3.  ISO2002 ID# _Li4wUaAiEea9x5aZm6UTkw.
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
/// Information describing the high level details of a split trade.
/// </summary>
[IsoId("_Li4wUaAiEea9x5aZm6UTkw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Split Trade Details")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SplitTradeDetails3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SplitTradeDetails3 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SplitTradeDetails3( AmountsAndValueDate1 reqTradeAmounts )
    {
        TradeAmounts = reqTradeAmounts;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the status of a foreign exchange trade in the system.
    /// </summary>
    [IsoId("_LtnZoaAiEea9x5aZm6UTkw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Status Details")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TradeData16? StatusDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TradeData16? StatusDetails { get; init; } 
    #else
    public TradeData16? StatusDetails { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts of the foreign exchange trade.
    /// </summary>
    [IsoId("_LtnZo6AiEea9x5aZm6UTkw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Trade Amounts")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountsAndValueDate1 TradeAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public AmountsAndValueDate1 TradeAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountsAndValueDate1 TradeAmounts { get; init; } 
    #else
    public AmountsAndValueDate1 TradeAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Exchange rate as agreed by the traders.
    /// </summary>
    [IsoId("_LtnZpaAiEea9x5aZm6UTkw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Agreed Rate")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AgreedRate3? AgreedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AgreedRate3? AgreedRate { get; init; } 
    #else
    public AgreedRate3? AgreedRate { get; set; } 
    #endif
    
    
    #nullable disable
    
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ReversalRequest4.  ISO2002 ID# _uVlPgU3_Eey_VecAUE-C9Q.
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
/// Data to request a Reversal.
/// </summary>
[IsoId("_uVlPgU3_Eey_VecAUE-C9Q")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Reversal Request")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReversalRequest4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReversalRequest4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReversalRequest4( ReversalReason1Code reqReversalReason )
    {
        ReversalReason = reqReversalReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Transaction to reverse.
    /// </summary>
    [IsoId("_ubzMQU3_Eey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reversal Transaction")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardPaymentTransaction120? ReversalTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardPaymentTransaction120? ReversalTransaction { get; init; } 
    #else
    public CardPaymentTransaction120? ReversalTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// Data linked to card loyalty during payment.
    /// </summary>
    [IsoId("_ubzMQ03_Eey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Loyalty Data")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LoyaltyRequestData3? LoyaltyData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LoyaltyRequestData3? LoyaltyData { get; init; } 
    #else
    public LoyaltyRequestData3? LoyaltyData { get; set; } 
    #endif
    
    /// <summary>
    /// Reason for this reversal.
    /// </summary>
    [IsoId("_ubzMRU3_Eey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reversal Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReversalReason1Code ReversalReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ReversalReason1Code ReversalReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReversalReason1Code ReversalReason { get; init; } 
    #else
    public ReversalReason1Code ReversalReason { get; set; } 
    #endif
    
    /// <summary>
    /// Amount to reverse (total or partial).
    /// </summary>
    [IsoId("_ubzMR03_Eey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reversed Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoImpliedCurrencyAndAmount? ReversedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ReversedAmount { get; init; } 
    #else
    public System.Decimal? ReversedAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Specific Customer Order linked with the reversal.
    /// </summary>
    [IsoId("_ubzMSU3_Eey_VecAUE-C9Q")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Customer Order")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CustomerOrder1? CustomerOrder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CustomerOrder1? CustomerOrder { get; init; } 
    #else
    public CustomerOrder1? CustomerOrder { get; set; } 
    #endif
    
    
    #nullable disable
    
}

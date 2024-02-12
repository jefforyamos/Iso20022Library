﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PendingBalance7.  ISO2002 ID# _P74IcRuyEeyhRdHRjakS2w.
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
/// Provides information about pending balance and pending transactions.
/// </summary>
[IsoId("_P74IcRuyEeyhRdHRjakS2w")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Pending Balance")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PendingBalance7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PendingBalance7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PendingBalance7( SignedQuantityFormat10 reqBalance )
    {
        Balance = reqBalance;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Signed quantity of balance.
    /// </summary>
    [IsoId("_QQcqQRuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Balance")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SignedQuantityFormat10 Balance { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public SignedQuantityFormat10 Balance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SignedQuantityFormat10 Balance { get; init; } 
    #else
    public SignedQuantityFormat10 Balance { get; set; } 
    #endif
    
    /// <summary>
    /// Overall process covering the trade and settlement transactions of financial instruments.
    /// </summary>
    [IsoId("_QQcqSRuyEeyhRdHRjakS2w")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Pending Transactions")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SettlementTypeAndIdentification25? PendingTransactions { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SettlementTypeAndIdentification25? PendingTransactions { get; init; } 
    #else
    public SettlementTypeAndIdentification25? PendingTransactions { get; set; } 
    #endif
    
    
    #nullable disable
    
}

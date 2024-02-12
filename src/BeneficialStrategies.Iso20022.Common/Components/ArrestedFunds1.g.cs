﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for ArrestedFunds1.  ISO2002 ID# _Qpd4YBt3Eeaiht5D4a9WSA.
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
/// Information about funds that have been arrested.
/// </summary>
[IsoId("_Qpd4YBt3Eeaiht5D4a9WSA")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Arrested Funds")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ArrestedFunds1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ArrestedFunds1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ArrestedFunds1( System.Decimal reqRemainingUnpaidAmount )
    {
        RemainingUnpaidAmount = reqRemainingUnpaidAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the arrest order assigned by the account servicer.
    /// </summary>
    [IsoId("_W_XnACG4EeaZx5-Tw7BKeQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Arrest Identification")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [StringLength(maximumLength: 10 ,MinimumLength = 1)]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax10Text? ArrestIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ArrestIdentification { get; init; } 
    #else
    public System.String? ArrestIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Total amount owed subject to arrest.
    /// </summary>
    [IsoId("_fvCwYBt3Eeaiht5D4a9WSA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Total Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? TotalAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? TotalAmount { get; init; } 
    #else
    public System.Decimal? TotalAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Remaining unpaid amount out of total amount owed subject to arrest.
    /// </summary>
    [IsoId("_yfPgABt3Eeaiht5D4a9WSA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Remaining Unpaid Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAndAmount RemainingUnpaidAmount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal RemainingUnpaidAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal RemainingUnpaidAmount { get; init; } 
    #else
    public System.Decimal RemainingUnpaidAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Funds blocked for settlement of the arrest order.
    /// </summary>
    [IsoId("_qz16kBt3Eeaiht5D4a9WSA")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Arrested Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoActiveCurrencyAndAmount? ArrestedAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ArrestedAmount { get; init; } 
    #else
    public System.Decimal? ArrestedAmount { get; set; } 
    #endif
    
    
    #nullable disable
    
}

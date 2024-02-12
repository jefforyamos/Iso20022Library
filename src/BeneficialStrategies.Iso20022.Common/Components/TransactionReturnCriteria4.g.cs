﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionReturnCriteria4.  ISO2002 ID# _hKQTse0gEeWGZ8O9Moj6Zw.
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
/// Defines the criteria used to report on a payment transaction.
/// </summary>
[IsoId("_hKQTse0gEeWGZ8O9Moj6Zw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Transaction Return Criteria")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionReturnCriteria4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Destination of the payment (be it a member or a system or both).
    /// </summary>
    [IsoId("_hUXR8-0gEeWGZ8O9Moj6Zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment To Return Criteria")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemReturnCriteria2? PaymentToReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemReturnCriteria2? PaymentToReturnCriteria { get; init; } 
    #else
    public SystemReturnCriteria2? PaymentToReturnCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Origin of the payment (be it a member or a system or both).
    /// </summary>
    [IsoId("_hUXR9e0gEeWGZ8O9Moj6Zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment From Return Criteria")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SystemReturnCriteria2? PaymentFromReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SystemReturnCriteria2? PaymentFromReturnCriteria { get; init; } 
    #else
    public SystemReturnCriteria2? PaymentFromReturnCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria used to report on the cash entry.
    /// </summary>
    [IsoId("_hUXR9-0gEeWGZ8O9Moj6Zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Account Cash Entry Return Criteria")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountCashEntryReturnCriteria3? AccountCashEntryReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountCashEntryReturnCriteria3? AccountCashEntryReturnCriteria { get; init; } 
    #else
    public AccountCashEntryReturnCriteria3? AccountCashEntryReturnCriteria { get; set; } 
    #endif
    
    /// <summary>
    /// Defines the criteria used to report on the payment.
    /// </summary>
    [IsoId("_hUXR-e0gEeWGZ8O9Moj6Zw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Return Criteria")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentReturnCriteria3? PaymentReturnCriteria { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentReturnCriteria3? PaymentReturnCriteria { get; init; } 
    #else
    public PaymentReturnCriteria3? PaymentReturnCriteria { get; set; } 
    #endif
    
    
    #nullable disable
    
}

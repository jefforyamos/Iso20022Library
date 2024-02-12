﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingTransaction9.  ISO2002 ID# _oFWZmR72EeSxevWRRWxNAg.
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
/// Identifies the underlying (group of) transaction(s) to which the resolution of investigation applies.
/// </summary>
[IsoId("_oFWZmR72EeSxevWRRWxNAg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Underlying Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingTransaction9
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides information on the original cancellation message, to which the resolution refers.
    /// </summary>
    [IsoId("_oXLwWR72EeSxevWRRWxNAg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Group Information And Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupHeader5? OriginalGroupInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupHeader5? OriginalGroupInformationAndStatus { get; init; } 
    #else
    public OriginalGroupHeader5? OriginalGroupInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original (group of) transactions, to which the cancellation status refers.
    /// </summary>
    [IsoId("_oXLwWx72EeSxevWRRWxNAg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Payment Information And Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInstruction10? OriginalPaymentInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInstruction10? OriginalPaymentInformationAndStatus { get; init; } 
    #else
    public OriginalPaymentInstruction10? OriginalPaymentInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_oXLwXR72EeSxevWRRWxNAg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Information And Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransaction53? TransactionInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransaction53? TransactionInformationAndStatus { get; init; } 
    #else
    public PaymentTransaction53? TransactionInformationAndStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}

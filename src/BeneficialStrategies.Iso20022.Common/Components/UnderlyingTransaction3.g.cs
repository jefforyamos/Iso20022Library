﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for UnderlyingTransaction3.  ISO2002 ID# _Pm2ePtp-Ed-ak6NoX_4Aeg_1632211747.
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
/// Set of elements used to identify the underlying (group of) transaction(s) to which the resolution of investigation applies.
/// </summary>
[IsoId("_Pm2ePtp-Ed-ak6NoX_4Aeg_1632211747")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Underlying Transaction")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record UnderlyingTransaction3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide information on the original cancellation message, to which the resolution refers.
    /// </summary>
    [IsoId("_Pm2eP9p-Ed-ak6NoX_4Aeg_1632211778")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Group Information And Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalGroupInformation24? OriginalGroupInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalGroupInformation24? OriginalGroupInformationAndStatus { get; init; } 
    #else
    public OriginalGroupInformation24? OriginalGroupInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the original (group of) transactions, to which the cancellation status refers.
    /// </summary>
    [IsoId("_Pm2eQNp-Ed-ak6NoX_4Aeg_1632212087")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Original Payment Information And Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalPaymentInformation3? OriginalPaymentInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalPaymentInformation3? OriginalPaymentInformationAndStatus { get; init; } 
    #else
    public OriginalPaymentInformation3? OriginalPaymentInformationAndStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Set of elements used to provide information on the original transactions to which the cancellation request message refers.
    /// </summary>
    [IsoId("_Pm2eQdp-Ed-ak6NoX_4Aeg_1678385318")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Information And Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentTransactionInformation33? TransactionInformationAndStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentTransactionInformation33? TransactionInformationAndStatus { get; init; } 
    #else
    public PaymentTransactionInformation33? TransactionInformationAndStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}

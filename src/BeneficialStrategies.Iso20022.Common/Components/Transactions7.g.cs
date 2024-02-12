﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Transactions7.  ISO2002 ID# _M4MEpZlPEee-Zps0fZQaFQ.
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
/// Reports on transactions.
/// </summary>
[IsoId("_M4MEpZlPEee-Zps0fZQaFQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Transactions")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transactions7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Common detailed payment instruction information.
    /// </summary>
    [IsoId("_NAXwSZlPEee-Zps0fZQaFQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Common Information")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentCommon3? PaymentCommonInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentCommon3? PaymentCommonInformation { get; init; } 
    #else
    public PaymentCommon3? PaymentCommonInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates the total number and sum of the transactions.
    /// </summary>
    [IsoId("_NAXwS5lPEee-Zps0fZQaFQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transactions Summary")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public NumberAndSumOfTransactions2? TransactionsSummary { get; init; } 
    #else
    public NumberAndSumOfTransactions2? TransactionsSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Reports either on the transaction information or on a business error.
    /// </summary>
    [IsoId("_NAXwTZlPEee-Zps0fZQaFQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Transaction Report")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    public TransactionReport4? TransactionReport { get; init;  } // Warning: Don't know multiplicity.
    // ID for the above is _NAXwTZlPEee-Zps0fZQaFQ
    
    
    #nullable disable
    
}

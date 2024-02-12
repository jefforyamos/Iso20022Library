﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for PaymentStatus3.  ISO2002 ID# _NhZZ05lPEee-Zps0fZQaFQ.
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
/// Payment status details.
/// </summary>
[IsoId("_NhZZ05lPEee-Zps0fZQaFQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Payment Status")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PaymentStatus3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of a transfer, in coded form, as assigned by the transaction administrator.
    /// </summary>
    [IsoId("_NqBxQ5lPEee-Zps0fZQaFQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Code")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentStatusCode6Choice_? Code { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatusCode6Choice_? Code { get; init; } 
    #else
    public PaymentStatusCode6Choice_? Code { get; set; } 
    #endif
    
    /// <summary>
    /// Date and time at which the status was assigned to the transfer.
    /// </summary>
    [IsoId("_NqBxRZlPEee-Zps0fZQaFQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Date Time")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? DateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? DateTime { get; init; } 
    #else
    public DateAndDateTime2Choice_? DateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Reason provided for the status of a transfer.
    /// </summary>
    [IsoId("_NqBxR5lPEee-Zps0fZQaFQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Reason")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentStatusReasonCode7Choice_? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentStatusReasonCode7Choice_? Reason { get; init; } 
    #else
    public PaymentStatusReasonCode7Choice_? Reason { get; set; } 
    #endif
    
    
    #nullable disable
    
}

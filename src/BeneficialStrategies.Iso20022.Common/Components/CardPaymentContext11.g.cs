﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentContext11.  ISO2002 ID# _sMw5QWl9EeSxgrJ0GX4SQQ.
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
/// Context in which the transaction is performed (payment and sale).
/// </summary>
[IsoId("_sMw5QWl9EeSxgrJ0GX4SQQ")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Card Payment Context")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentContext11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CardPaymentContext11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CardPaymentContext11( PaymentContext11 reqPaymentContext )
    {
        PaymentContext = reqPaymentContext;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_sZ-14Gl9EeSxgrJ0GX4SQQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Context")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentContext11 PaymentContext { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public PaymentContext11 PaymentContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentContext11 PaymentContext { get; init; } 
    #else
    public PaymentContext11 PaymentContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_sZ-14ml9EeSxgrJ0GX4SQQ")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Sale Context")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleContext1? SaleContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleContext1? SaleContext { get; init; } 
    #else
    public SaleContext1? SaleContext { get; set; } 
    #endif
    
    
    #nullable disable
    
}

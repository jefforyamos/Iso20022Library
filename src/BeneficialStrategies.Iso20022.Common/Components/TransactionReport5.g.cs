﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for TransactionReport5.  ISO2002 ID# _WxDT3249EeiU9cctagi5ow.
// Copyright 2024 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
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
/// Provides details on the payment transactions.
/// </summary>
[IsoId("_WxDT3249EeiU9cctagi5ow")]
[DisplayName("Transaction Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionReport5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionReport5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionReport5( PaymentIdentification6Choice_ reqPaymentIdentification,TransactionOrError4Choice_ reqTransactionOrError )
    {
        PaymentIdentification = reqPaymentIdentification;
        TransactionOrError = reqTransactionOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference to the instruction related to the payment for which information is requested.
    /// </summary>
    [IsoId("_W6b5U249EeiU9cctagi5ow")]
    [DisplayName("Payment Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtId")]
    #endif
    [IsoXmlTag("PmtId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PaymentIdentification6Choice_ PaymentIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PaymentIdentification6Choice_ PaymentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentIdentification6Choice_ PaymentIdentification { get; init; } 
    #else
    public PaymentIdentification6Choice_ PaymentIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested information on the payment transaction when information has not been found.
    /// </summary>
    [IsoId("_W6b5VW49EeiU9cctagi5ow")]
    [DisplayName("Transaction Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxOrErr")]
    #endif
    [IsoXmlTag("TxOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionOrError4Choice_ TransactionOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionOrError4Choice_ TransactionOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionOrError4Choice_ TransactionOrError { get; init; } 
    #else
    public TransactionOrError4Choice_ TransactionOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}

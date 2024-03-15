﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CardPaymentContext26.  ISO2002 ID# _XPBhMdpsEeearpaEPXv9UA.
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
/// Context in which the transaction is performed (payment and sale).
/// </summary>
[IsoId("_XPBhMdpsEeearpaEPXv9UA")]
[DisplayName("Card Payment Context")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardPaymentContext26
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Context of the card payment transaction.
    /// </summary>
    [IsoId("_XXrG4dpsEeearpaEPXv9UA")]
    [DisplayName("Payment Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtCntxt")]
    #endif
    [IsoXmlTag("PmtCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PaymentContext24? PaymentContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PaymentContext24? PaymentContext { get; init; } 
    #else
    public PaymentContext24? PaymentContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the sale involving the card payment transaction.
    /// </summary>
    [IsoId("_XXrG49psEeearpaEPXv9UA")]
    [DisplayName("Sale Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleCntxt")]
    #endif
    [IsoXmlTag("SaleCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SaleContext2? SaleContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SaleContext2? SaleContext { get; init; } 
    #else
    public SaleContext2? SaleContext { get; set; } 
    #endif
    
    /// <summary>
    /// Context of the direct debit transaction.
    /// </summary>
    [IsoId("_fJgEcNpsEeearpaEPXv9UA")]
    [DisplayName("Direct Debit Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DrctDbtCntxt")]
    #endif
    [IsoXmlTag("DrctDbtCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CardDirectDebit1? DirectDebitContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CardDirectDebit1? DirectDebitContext { get; init; } 
    #else
    public CardDirectDebit1? DirectDebitContext { get; set; } 
    #endif
    
    
    #nullable disable
    
}

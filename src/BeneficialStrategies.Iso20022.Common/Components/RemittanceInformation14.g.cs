﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RemittanceInformation14.  ISO2002 ID# _j9adUa9UEeeJJK1oRb-jTw.
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
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
/// </summary>
[IsoId("_j9adUa9UEeeJJK1oRb-jTw")]
[DisplayName("Remittance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RemittanceInformation14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in an unstructured form.
    /// </summary>
    [IsoId("_kIBx469UEeeJJK1oRb-jTw")]
    [DisplayName("Unstructured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Ustrd")]
    #endif
    [IsoXmlTag("Ustrd")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Unstructured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Unstructured { get; init; } 
    #else
    public System.String? Unstructured { get; set; } 
    #endif
    
    /// <summary>
    /// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
    /// </summary>
    [IsoId("_kIBx5a9UEeeJJK1oRb-jTw")]
    [DisplayName("Structured")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Strd")]
    #endif
    [IsoXmlTag("Strd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StructuredRemittanceInformation14? Structured { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StructuredRemittanceInformation14? Structured { get; init; } 
    #else
    public StructuredRemittanceInformation14? Structured { get; set; } 
    #endif
    
    
    #nullable disable
    
}

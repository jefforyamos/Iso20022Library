﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for AdditionalQueryParameters12.  ISO2002 ID# _8QboD5NLEeWGlc8L7oPDIg.
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
/// Additional specific query criteria.
/// </summary>
[IsoId("_8QboD5NLEeWGlc8L7oPDIg")]
[DisplayName("Additional Query Parameters")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record AdditionalQueryParameters12
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status.
    /// </summary>
    [IsoId("_8QboEZNLEeWGlc8L7oPDIg")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Status22Choice_? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Status22Choice_? Status { get; init; } 
    #else
    public Status22Choice_? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Request to obtain a Securities Transaction Pending Report for transactions with the specified status reason.
    /// </summary>
    [IsoId("_8QboFZNLEeWGlc8L7oPDIg")]
    [DisplayName("Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Rsn")]
    #endif
    [IsoXmlTag("Rsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Reason17Choice_? Reason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Reason17Choice_? Reason { get; init; } 
    #else
    public Reason17Choice_? Reason { get; set; } 
    #endif
    
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_8QboGZNLEeWGlc8L7oPDIg")]
    [DisplayName("Financial Instrument Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FinInstrmId")]
    #endif
    [IsoXmlTag("FinInstrmId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification20? FinancialInstrumentIdentification { get; init; } 
    #else
    public SecurityIdentification20? FinancialInstrumentIdentification { get; set; } 
    #endif
    
    
    #nullable disable
    
}

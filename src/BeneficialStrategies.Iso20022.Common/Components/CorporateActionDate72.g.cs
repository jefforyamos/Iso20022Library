﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate72.  ISO2002 ID# _k9vXZc3xEee5nJBZsW8MFQ.
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
/// Specifies corporate action dates.
/// </summary>
[IsoId("_k9vXZc3xEee5nJBZsW8MFQ")]
[DisplayName("Corporate Action Date")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate72
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionDate72 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionDate72( DateFormat49Choice_ reqPaymentDate )
    {
        PaymentDate = reqPaymentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date/time on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_k9vXac3xEee5nJBZsW8MFQ")]
    [DisplayName("Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PmtDt")]
    #endif
    [IsoXmlTag("PmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat49Choice_ PaymentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DateFormat49Choice_ PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_ PaymentDate { get; init; } 
    #else
    public DateFormat49Choice_ PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_k9vXcc3xEee5nJBZsW8MFQ")]
    [DisplayName("Value Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ValDt")]
    #endif
    [IsoXmlTag("ValDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat55Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat55Choice_? ValueDate { get; init; } 
    #else
    public DateFormat55Choice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_k9vXec3xEee5nJBZsW8MFQ")]
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FXRateFxgDt")]
    #endif
    [IsoXmlTag("FXRateFxgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? ForeignExchangeRateFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? ForeignExchangeRateFixingDate { get; init; } 
    #else
    public DateFormat49Choice_? ForeignExchangeRateFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_k9vXgc3xEee5nJBZsW8MFQ")]
    [DisplayName("Earliest Payment Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EarlstPmtDt")]
    #endif
    [IsoXmlTag("EarlstPmtDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat49Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat49Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat49Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}

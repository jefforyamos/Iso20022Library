﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate17.  ISO2002 ID# _jMBm0_ZFEd-2Jsl2KtUQCw.
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
[IsoId("_jMBm0_ZFEd-2Jsl2KtUQCw")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Date")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate17
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionDate17 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionDate17( DateFormat19Choice_ reqPaymentDate )
    {
        PaymentDate = reqPaymentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_jMBm1fZFEd-2Jsl2KtUQCw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat19Choice_ PaymentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DateFormat19Choice_ PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_ PaymentDate { get; init; } 
    #else
    public DateFormat19Choice_ PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which assets become available to the account owner (in a credit entry), or cease to be available to the account owner (in a debit entry).
    /// </summary>
    [IsoId("_jMBm1_ZFEd-2Jsl2KtUQCw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat11Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat11Choice_? ValueDate { get; init; } 
    #else
    public DateFormat11Choice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_jMBm2fZFEd-2Jsl2KtUQCw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? ForeignExchangeRateFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? ForeignExchangeRateFixingDate { get; init; } 
    #else
    public DateFormat19Choice_? ForeignExchangeRateFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_jMBm2_ZFEd-2Jsl2KtUQCw")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Earliest Payment Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat19Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat19Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat19Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}

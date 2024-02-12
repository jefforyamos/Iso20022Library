﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for CorporateActionDate56.  ISO2002 ID# _ctl9g5KQEeWHWpTQn1FFVg.
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
[IsoId("_ctl9g5KQEeWHWpTQn1FFVg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Corporate Action Date")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionDate56
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionDate56 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionDate56( DateFormat34Choice_ reqPaymentDate )
    {
        PaymentDate = reqPaymentDate;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Date on which the movement is due to take place (cash and/or securities).
    /// </summary>
    [IsoId("_ctl9hZKQEeWHWpTQn1FFVg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Payment Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DateFormat34Choice_ PaymentDate { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public DateFormat34Choice_ PaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat34Choice_ PaymentDate { get; init; } 
    #else
    public DateFormat34Choice_ PaymentDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time when calculating economic benefit for a cash amount.
    /// </summary>
    [IsoId("_ctl9jZKQEeWHWpTQn1FFVg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Value Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat39Choice_? ValueDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat39Choice_? ValueDate { get; init; } 
    #else
    public DateFormat39Choice_? ValueDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date/time at which a foreign exchange rate will be determined.
    /// </summary>
    [IsoId("_ctl9lZKQEeWHWpTQn1FFVg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Foreign Exchange Rate Fixing Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat34Choice_? ForeignExchangeRateFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat34Choice_? ForeignExchangeRateFixingDate { get; init; } 
    #else
    public DateFormat34Choice_? ForeignExchangeRateFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date on which a payment can be made, for example, if payment date is a non-business day or to indicate the first payment date of an offer.
    /// </summary>
    [IsoId("_ctl9nZKQEeWHWpTQn1FFVg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Earliest Payment Date")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat34Choice_? EarliestPaymentDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat34Choice_? EarliestPaymentDate { get; init; } 
    #else
    public DateFormat34Choice_? EarliestPaymentDate { get; set; } 
    #endif
    
    
    #nullable disable
    
}

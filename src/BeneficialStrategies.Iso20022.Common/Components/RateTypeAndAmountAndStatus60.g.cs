﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateTypeAndAmountAndStatus60.  ISO2002 ID# _-lkiDAVSEeqjd8n6wD9JVw.
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
/// Specifies the value expressed as a rate and an amount.
/// </summary>
[IsoId("_-lkiDAVSEeqjd8n6wD9JVw")]
[DisplayName("Rate Type And Amount And Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RateTypeAndAmountAndStatus60
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RateTypeAndAmountAndStatus60 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RateTypeAndAmountAndStatus60( RateType81Choice_ reqRateType,System.Decimal reqAmount )
    {
        RateType = reqRateType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_-lkiDgVSEeqjd8n6wD9JVw")]
    [DisplayName("Rate Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateTp")]
    #endif
    [IsoXmlTag("RateTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RateType81Choice_ RateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required RateType81Choice_ RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType81Choice_ RateType { get; init; } 
    #else
    public RateType81Choice_ RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_-lkiFgVSEeqjd8n6wD9JVw")]
    [DisplayName("Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Amt")]
    #endif
    [IsoXmlTag("Amt")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINActiveCurrencyAnd13DecimalAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Amount { get; init; } 
    #else
    public System.Decimal Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_-lkiGAVSEeqjd8n6wD9JVw")]
    [DisplayName("Rate Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RateSts")]
    #endif
    [IsoXmlTag("RateSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateStatus4Choice_? RateStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateStatus4Choice_? RateStatus { get; init; } 
    #else
    public RateStatus4Choice_? RateStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}

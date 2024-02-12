﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for RateTypeAndAmountAndStatus41.  ISO2002 ID# _ShoBV5b9Eee8S7xwGG7Veg.
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
[IsoId("_ShoBV5b9Eee8S7xwGG7Veg")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Rate Type And Amount And Status")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record RateTypeAndAmountAndStatus41
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a RateTypeAndAmountAndStatus41 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public RateTypeAndAmountAndStatus41( RateType71Choice_ reqRateType,System.Decimal reqAmount )
    {
        RateType = reqRateType;
        Amount = reqAmount;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Value expressed as a rate type.
    /// </summary>
    [IsoId("_SwgKwZb9Eee8S7xwGG7Veg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate Type")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required RateType71Choice_ RateType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public RateType71Choice_ RateType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateType71Choice_ RateType { get; init; } 
    #else
    public RateType71Choice_ RateType { get; set; } 
    #endif
    
    /// <summary>
    /// Value expressed as an amount.
    /// </summary>
    [IsoId("_SwgKyZb9Eee8S7xwGG7Veg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Amount")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveCurrencyAnd13DecimalAmount Amount { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public System.Decimal Amount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Amount { get; init; } 
    #else
    public System.Decimal Amount { get; set; } 
    #endif
    
    /// <summary>
    /// Value expressed as a rate status.
    /// </summary>
    [IsoId("_SwgKy5b9Eee8S7xwGG7Veg")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Rate Status")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateStatus3Choice_? RateStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateStatus3Choice_? RateStatus { get; init; } 
    #else
    public RateStatus3Choice_? RateStatus { get; set; } 
    #endif
    
    
    #nullable disable
    
}

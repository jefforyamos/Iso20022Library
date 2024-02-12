﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for Balance6.  ISO2002 ID# _kbl4YTnFEeWV5sr121Fc8A.
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
/// Net position of a segregated holding, in a single security, within the overall position held in a securities account. A securities balance is calculated from the sum of securities' receipts minus the sum of securities' deliveries.
/// </summary>
[IsoId("_kbl4YTnFEeWV5sr121Fc8A")]
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
[DisplayName("Balance")]
#endif
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Balance6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Balance6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Balance6( ShortLong1Code reqShortLongIndicator,BalanceQuantity9Choice_ reqQuantity )
    {
        ShortLongIndicator = reqShortLongIndicator;
        Quantity = reqQuantity;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indication that the position is short or long.
    /// </summary>
    [IsoId("_lRmTUznFEeWV5sr121Fc8A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Short Long Indicator")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ShortLong1Code ShortLongIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public ShortLong1Code ShortLongIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShortLong1Code ShortLongIndicator { get; init; } 
    #else
    public ShortLong1Code ShortLongIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Total quantity of financial instruments of the balance.
    /// </summary>
    [IsoId("_lRmTWznFEeWV5sr121Fc8A")]
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    [DisplayName("Quantity")]
    #endif
    #if DECLARE_DATACONTRACT
    [DataMember]
    #endif
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BalanceQuantity9Choice_ Quantity { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public BalanceQuantity9Choice_ Quantity { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BalanceQuantity9Choice_ Quantity { get; init; } 
    #else
    public BalanceQuantity9Choice_ Quantity { get; set; } 
    #endif
    
    
    #nullable disable
    
}

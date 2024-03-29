﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for QuantityToQuantityRatio2.  ISO2002 ID# _WjNMUNp-Ed-ak6NoX_4Aeg_511377656.
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
/// Ratio expressed as a quotient of quantities.
/// </summary>
[IsoId("_WjNMUNp-Ed-ak6NoX_4Aeg_511377656")]
[DisplayName("Quantity To Quantity Ratio")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record QuantityToQuantityRatio2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a QuantityToQuantityRatio2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public QuantityToQuantityRatio2( System.UInt64 reqQuantity1,System.UInt64 reqQuantity2 )
    {
        Quantity1 = reqQuantity1;
        Quantity2 = reqQuantity2;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Numerator of the quotient of quantities.
    /// </summary>
    [IsoId("_WjNMUdp-Ed-ak6NoX_4Aeg_2126904066")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty1")]
    #endif
    [IsoXmlTag("Qty1")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINDecimalNumber Quantity1 { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Quantity1 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Quantity1 { get; init; } 
    #else
    public System.UInt64 Quantity1 { get; set; } 
    #endif
    
    /// <summary>
    /// Denominator of the quotient of quantities.
    /// </summary>
    [IsoId("_WjNMUtp-Ed-ak6NoX_4Aeg_-1402106980")]
    [DisplayName("Quantity")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Qty2")]
    #endif
    [IsoXmlTag("Qty2")]
    [IsoSimpleType(IsoSimpleType.RestrictedFINDecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoRestrictedFINDecimalNumber Quantity2 { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Quantity2 { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Quantity2 { get; init; } 
    #else
    public System.UInt64 Quantity2 { get; set; } 
    #endif
    
    
    #nullable disable
    
}

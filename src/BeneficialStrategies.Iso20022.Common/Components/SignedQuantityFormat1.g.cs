﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SignedQuantityFormat1.  ISO2002 ID# _Q0of9Np-Ed-ak6NoX_4Aeg_-761434658.
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
/// Signed quantity of security formats.
/// </summary>
[IsoId("_Q0of9Np-Ed-ak6NoX_4Aeg_-761434658")]
[DisplayName("Signed Quantity Format")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SignedQuantityFormat1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SignedQuantityFormat1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SignedQuantityFormat1( ShortLong1Code reqShortLongPosition,Quantity2Choice_ reqQuantityChoice )
    {
        ShortLongPosition = reqShortLongPosition;
        QuantityChoice = reqQuantityChoice;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Sign of the quantity of security.
    /// </summary>
    [IsoId("_Q0of9dp-Ed-ak6NoX_4Aeg_1211863483")]
    [DisplayName("Short Long Position")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ShrtLngPos")]
    #endif
    [IsoXmlTag("ShrtLngPos")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ShortLong1Code ShortLongPosition { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ShortLong1Code ShortLongPosition { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ShortLong1Code ShortLongPosition { get; init; } 
    #else
    public ShortLong1Code ShortLongPosition { get; set; } 
    #endif
    
    /// <summary>
    /// Choice between different quantity of security formats.
    /// </summary>
    [IsoId("_Q0of9tp-Ed-ak6NoX_4Aeg_1680090925")]
    [DisplayName("Quantity Choice")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="QtyChc")]
    #endif
    [IsoXmlTag("QtyChc")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Quantity2Choice_ QuantityChoice { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Quantity2Choice_ QuantityChoice { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Quantity2Choice_ QuantityChoice { get; init; } 
    #else
    public Quantity2Choice_ QuantityChoice { get; set; } 
    #endif
    
    
    #nullable disable
    
}

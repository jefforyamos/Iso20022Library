﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for SettlementDataRate2.  ISO2002 ID# _vW5JAY0SEemUAO64Q252gQ.
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
/// Specifies the volume and value percentage rates of settlement instructions.
/// </summary>
[IsoId("_vW5JAY0SEemUAO64Q252gQ")]
[DisplayName("Settlement Data Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SettlementDataRate2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SettlementDataRate2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SettlementDataRate2( System.Decimal reqVolume,System.Decimal reqValue )
    {
        Volume = reqVolume;
        Value = reqValue;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the rate, in terms of volume, of the failed settlement instructions compared to the total volume, of settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_vb6L4Y0SEemUAO64Q252gQ")]
    [DisplayName("Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vol")]
    #endif
    [IsoXmlTag("Vol")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Volume { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Volume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Volume { get; init; } 
    #else
    public System.Decimal Volume { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the rate, in terms of value, of the failed settlement instructions compared to the total value of settlement instructions performed (settled and failed) during the period covered by the report.
    /// </summary>
    [IsoId("_vb6L440SEemUAO64Q252gQ")]
    [DisplayName("Value")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Val")]
    #endif
    [IsoXmlTag("Val")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoPercentageRate Value { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Value { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Value { get; init; } 
    #else
    public System.Decimal Value { get; set; } 
    #endif
    
    
    #nullable disable
    
}

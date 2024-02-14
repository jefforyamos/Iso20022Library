﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by ComponentGenerator for NumberAndVolume2.  ISO2002 ID# _paGL8WlAEeaLAKoEUNsD9g.
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
/// Detail the number and the volume, defined by currency amount, for use in a transaction.
/// </summary>
[IsoId("_paGL8WlAEeaLAKoEUNsD9g")]
[DisplayName("Number And Volume")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record NumberAndVolume2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a NumberAndVolume2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public NumberAndVolume2( System.UInt64 reqNumber,System.Decimal reqVolume )
    {
        Number = reqNumber;
        Volume = reqVolume;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Total number of specific transaction types executed on the reporting day.
    /// </summary>
    [IsoId("_pi_CMWlAEeaLAKoEUNsD9g")]
    [DisplayName("Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Nb")]
    #endif
    [IsoXmlTag("Nb")]
    [IsoSimpleType(IsoSimpleType.DecimalNumberFraction5)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoDecimalNumberFraction5 Number { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.UInt64 Number { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64 Number { get; init; } 
    #else
    public System.UInt64 Number { get; set; } 
    #endif
    
    /// <summary>
    /// Total volume of specific transactions executed on the reporting day.
    /// </summary>
    [IsoId("_pi_CM2lAEeaLAKoEUNsD9g")]
    [DisplayName("Volume")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Vol")]
    #endif
    [IsoXmlTag("Vol")]
    [IsoSimpleType(IsoSimpleType.ActiveOrHistoricCurrencyAndAmount)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoActiveOrHistoricCurrencyAndAmount Volume { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.Decimal Volume { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal Volume { get; init; } 
    #else
    public System.Decimal Volume { get; set; } 
    #endif
    
    
    #nullable disable
    
}

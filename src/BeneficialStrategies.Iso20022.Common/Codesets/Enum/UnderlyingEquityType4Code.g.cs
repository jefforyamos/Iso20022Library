﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnderlyingEquityType4Code.  ISO2002 ID# _U38OIGlOEeaLAKoEUNsD9g.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type for a contract for equity derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_U38OIGlOEeaLAKoEUNsD9g")]
[Description(@"Specifies the type for a contract for equity derivatives.")]
[DerivedFrom(typeof(UnderlyingTypeV2Code))]
public enum UnderlyingEquityType4Code
{
    /// <summary>
    /// Underlying is a stock index.
    /// Encoded/decoded by serializers as "StockIndex".
    /// </summary>
    [EnumMember(Value = "STIX")]
    [IsoId("_u5AjUWlOEeaLAKoEUNsD9g")]
    [Description(@"Underlying is a stock index.")]
    StockIndex,
    
    /// <summary>
    /// Underlying is a dividend index.
    /// Encoded/decoded by serializers as "DividendIndex".
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_vggBIWlOEeaLAKoEUNsD9g")]
    [Description(@"Underlying is a dividend index.")]
    DividendIndex,
    
    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_v6xiUWlOEeaLAKoEUNsD9g")]
    [Description(@"Underlying is of other type.")]
    Other,
    
    /// <summary>
    /// Underlying is a volatility index.
    /// Encoded/decoded by serializers as "VolatilityIndex".
    /// </summary>
    [EnumMember(Value = "VOLI")]
    [IsoId("_wUg4AWlOEeaLAKoEUNsD9g")]
    [Description(@"Underlying is a volatility index.")]
    VolatilityIndex,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnderlyingEquityType4CodeMetadataExtensions
{
    private static readonly UnderlyingEquityType4CodeDropdownSource _dropdownSource = new UnderlyingEquityType4CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnderlyingEquityType4CodeDropdownRow GetMetadata(this UnderlyingEquityType4Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



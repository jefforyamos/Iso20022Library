﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnderlyingEquityType6Code.  ISO2002 ID# _AOZLsIHCEeaalK9UbuVGFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type for a contract for equity derivatives.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_AOZLsIHCEeaalK9UbuVGFw")]
[Description(@"Specifies the type for a contract for equity derivatives.")]
[DerivedFrom(typeof(UnderlyingTypeV3Code))]
public enum UnderlyingEquityType6Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Basket".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_kVvNUYHCEeaalK9UbuVGFw")]
    [Description(@"??")]
    Basket,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "DividendIndex".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_khfKUYHCEeaalK9UbuVGFw")]
    [Description(@"??")]
    DividendIndex,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ExchangeTradedFund".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_k8RB0YHCEeaalK9UbuVGFw")]
    [Description(@"??")]
    ExchangeTradedFund,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_lhw7kYHCEeaalK9UbuVGFw")]
    [Description(@"??")]
    Other,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Share".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_l3es4YHCEeaalK9UbuVGFw")]
    [Description(@"??")]
    Share,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StockDividend".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mUMeEYHCEeaalK9UbuVGFw")]
    [Description(@"??")]
    StockDividend,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "StockIndex".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mnPV4YHCEeaalK9UbuVGFw")]
    [Description(@"??")]
    StockIndex,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "VolatilityIndex".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_mysX8YHCEeaalK9UbuVGFw")]
    [Description(@"??")]
    VolatilityIndex,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class UnderlyingEquityType6CodeMetadataExtensions
{
    private static readonly UnderlyingEquityType6CodeDropdownSource _dropdownSource = new UnderlyingEquityType6CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IUnderlyingEquityType6CodeDropdownRow GetMetadata(this UnderlyingEquityType6Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


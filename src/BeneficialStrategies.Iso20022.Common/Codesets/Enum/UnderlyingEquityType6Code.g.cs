﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for UnderlyingEquityType6Code.  ISO2002 ID# _AOZLsIHCEeaalK9UbuVGFw.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

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
    /// Underlying is a basket.
    /// Encoded/decoded by serializers as "BSKT".
    /// </summary>
    [EnumMember(Value = "BSKT")]
    [IsoId("_kVvNUYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a basket.")]
    Basket = UnderlyingTypeV3Code.Basket, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is a dividend index.
    /// Encoded/decoded by serializers as "DIVI".
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_khfKUYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a dividend index.")]
    DividendIndex = UnderlyingTypeV3Code.DividendIndex, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is an exchange traded fund.
    /// Encoded/decoded by serializers as "ETFS".
    /// </summary>
    [EnumMember(Value = "ETFS")]
    [IsoId("_k8RB0YHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is an exchange traded fund.")]
    ExchangeTradedFund = UnderlyingTypeV3Code.ExchangeTradedFund, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is of other type.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_lhw7kYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is of other type.")]
    Other = UnderlyingTypeV3Code.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is a share.
    /// Encoded/decoded by serializers as "SHRS".
    /// </summary>
    [EnumMember(Value = "SHRS")]
    [IsoId("_l3es4YHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a share.")]
    Share = UnderlyingTypeV3Code.Share, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is a stock dividend.
    /// Encoded/decoded by serializers as "DVSE".
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_mUMeEYHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a stock dividend.")]
    StockDividend = UnderlyingTypeV3Code.StockDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is a stock index.
    /// Encoded/decoded by serializers as "STIX".
    /// </summary>
    [EnumMember(Value = "STIX")]
    [IsoId("_mnPV4YHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a stock index.")]
    StockIndex = UnderlyingTypeV3Code.StockIndex, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Underlying is a volatility index.
    /// Encoded/decoded by serializers as "VOLI".
    /// </summary>
    [EnumMember(Value = "VOLI")]
    [IsoId("_mysX8YHCEeaalK9UbuVGFw")]
    [Description(@"Underlying is a volatility index.")]
    VolatilityIndex = UnderlyingTypeV3Code.VolatilityIndex, // same ordinal as derivation source for type conversions
    
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



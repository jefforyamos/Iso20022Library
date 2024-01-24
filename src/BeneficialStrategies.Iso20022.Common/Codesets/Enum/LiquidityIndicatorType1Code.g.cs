﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for LiquidityIndicatorType1Code.  ISO2002 ID# _afCItNp-Ed-ak6NoX_4Aeg_1937966255.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the market and statistic conditions upon which a liquidity indicator has been computed.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_afCItNp-Ed-ak6NoX_4Aeg_1937966255")]
[Description(@"Specifies the market and statistic conditions upon which a liquidity indicator has been computed.")]
[DerivedFrom(typeof(LiquidityIndicatorTypeCode))]
public enum LiquidityIndicatorType1Code
{
    /// <summary>
    /// Computation is on the average value of the price of a security over a period of five days.
    /// Encoded/decoded by serializers as "FIVE".
    /// </summary>
    [EnumMember(Value = "FIVE")]
    [IsoId("_afCItdp-Ed-ak6NoX_4Aeg_1985065189")]
    [Description(@"Computation is on the average value of the price of a security over a period of five days.")]
    FiveDayMovingAverage = LiquidityIndicatorTypeCode.FiveDayMovingAverage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Computation is on the average value of the price of a security over a period of 20 days.
    /// Encoded/decoded by serializers as "TWEN".
    /// </summary>
    [EnumMember(Value = "TWEN")]
    [IsoId("_afCIttp-Ed-ak6NoX_4Aeg_1985065206")]
    [Description(@"Computation is on the average value of the price of a security over a period of 20 days.")]
    TwentyDayMovingAverage = LiquidityIndicatorTypeCode.TwentyDayMovingAverage, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Computation is on the standard market conditions and volume.
    /// Encoded/decoded by serializers as "NORM".
    /// </summary>
    [EnumMember(Value = "NORM")]
    [IsoId("_afCIt9p-Ed-ak6NoX_4Aeg_1985065379")]
    [Description(@"Computation is on the standard market conditions and volume.")]
    NormalMarketSize = LiquidityIndicatorTypeCode.NormalMarketSize, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class LiquidityIndicatorType1CodeMetadataExtensions
{
    private static readonly LiquidityIndicatorType1CodeDropdownSource _dropdownSource = new LiquidityIndicatorType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ILiquidityIndicatorType1CodeDropdownRow GetMetadata(this LiquidityIndicatorType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



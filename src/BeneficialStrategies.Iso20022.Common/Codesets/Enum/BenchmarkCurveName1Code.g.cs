﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BenchmarkCurveName1Code.  ISO2002 ID# _zd5TVQ93EeGeV5vP7Mvdig_1742179205.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identifies a benchmark curve name.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zd5TVQ93EeGeV5vP7Mvdig_1742179205")]
[Description(@"Identifies a benchmark curve name.")]
[DerivedFrom(typeof(BenchmarkCurveNameCode))]
public enum BenchmarkCurveName1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MuniAAA".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zeDEUA93EeGeV5vP7Mvdig_-730272138")]
    [Description(@"??")]
    MuniAAA,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "FutureSWAP".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zeDEUQ93EeGeV5vP7Mvdig_1565837077")]
    [Description(@"??")]
    FutureSWAP,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LIBID".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zeDEUg93EeGeV5vP7Mvdig_2008825569")]
    [Description(@"??")]
    LIBID,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "LIBOR".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zeDEUw93EeGeV5vP7Mvdig_-2118728291")]
    [Description(@"??")]
    LIBOR,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "SWAP".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zeDEVA93EeGeV5vP7Mvdig_1541207159")]
    [Description(@"??")]
    SWAP,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Treasury".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zeDEVQ93EeGeV5vP7Mvdig_-1675739799")]
    [Description(@"??")]
    Treasury,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Euribor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zeDEVg93EeGeV5vP7Mvdig_155183370")]
    [Description(@"??")]
    Euribor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pfandbriefe".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zeMOQA93EeGeV5vP7Mvdig_609270639")]
    [Description(@"??")]
    Pfandbriefe,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BenchmarkCurveName1CodeMetadataExtensions
{
    private static readonly BenchmarkCurveName1CodeDropdownSource _dropdownSource = new BenchmarkCurveName1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBenchmarkCurveName1CodeDropdownRow GetMetadata(this BenchmarkCurveName1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


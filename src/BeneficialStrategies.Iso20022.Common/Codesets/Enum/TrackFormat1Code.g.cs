﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TrackFormat1Code.  ISO2002 ID# _ux3yUNkWEeiojJsa6FYyew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Use to identify format of a track on a card or other documents like checks.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ux3yUNkWEeiojJsa6FYyew")]
[Description(@"Use to identify format of a track on a card or other documents like checks.")]
[DerivedFrom(typeof(TrackFormatCode))]
public enum TrackFormat1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "AAMVAFormat".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zTyeUdkWEeiojJsa6FYyew")]
    [Description(@"??")]
    AAMVAFormat,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "CMC7CheckFormat".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zXWvsdkWEeiojJsa6FYyew")]
    [Description(@"??")]
    CMC7CheckFormat,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "E13BCheckFormat".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zap7UdkWEeiojJsa6FYyew")]
    [Description(@"??")]
    E13BCheckFormat,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISOFormat".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zfPgYdkWEeiojJsa6FYyew")]
    [Description(@"??")]
    ISOFormat,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "JISIFormat".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zh8PEdkWEeiojJsa6FYyew")]
    [Description(@"??")]
    JISIFormat,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "JISIIFormat".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_zlYkodkWEeiojJsa6FYyew")]
    [Description(@"??")]
    JISIIFormat,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TrackFormat1CodeMetadataExtensions
{
    private static readonly TrackFormat1CodeDropdownSource _dropdownSource = new TrackFormat1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITrackFormat1CodeDropdownRow GetMetadata(this TrackFormat1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


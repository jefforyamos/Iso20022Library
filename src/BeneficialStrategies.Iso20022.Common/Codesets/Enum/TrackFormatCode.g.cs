﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TrackFormatCode.  ISO2002 ID# _Ug3jsNkWEeiojJsa6FYyew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Card and check track format.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Ug3jsNkWEeiojJsa6FYyew")]
[Description(@"Card and check track format.")]
public enum TrackFormatCode
{
    /// <summary>
    /// ISO card track format - ISO 7813 - ISO 4909.
    /// Encoded/decoded by serializers as "ISOF".
    /// </summary>
    [EnumMember(Value = "ISOF")]
    [IsoId("_ZVIj8NkWEeiojJsa6FYyew")]
    [Description(@"ISO card track format - ISO 7813 - ISO 4909.")]
    ISOFormat,
    
    /// <summary>
    /// Japanese track format I.
    /// Encoded/decoded by serializers as "JIS1".
    /// </summary>
    [EnumMember(Value = "JIS1")]
    [IsoId("_c6T64NkWEeiojJsa6FYyew")]
    [Description(@"Japanese track format I.")]
    JISIFormat,
    
    /// <summary>
    /// Japanese track format II.
    /// Encoded/decoded by serializers as "JIS2".
    /// </summary>
    [EnumMember(Value = "JIS2")]
    [IsoId("_g0ZK0NkWEeiojJsa6FYyew")]
    [Description(@"Japanese track format II.")]
    JISIIFormat,
    
    /// <summary>
    /// American driver license.
    /// Encoded/decoded by serializers as "AAMV".
    /// </summary>
    [EnumMember(Value = "AAMV")]
    [IsoId("_jnsY4NkWEeiojJsa6FYyew")]
    [Description(@"American driver license.")]
    AAMVAFormat,
    
    /// <summary>
    /// Magnetic Ink Character Recognition, using the CMC-7 font - ISO 1004 Line at the bottom of a check containing the bank account and the check number.
    /// Encoded/decoded by serializers as "CMC7".
    /// </summary>
    [EnumMember(Value = "CMC7")]
    [IsoId("_mjXf0NkWEeiojJsa6FYyew")]
    [Description(@"Magnetic Ink Character Recognition, using the CMC-7 font - ISO 1004 Line at the bottom of a check containing the bank account and the check number.")]
    CMC7CheckFormat,
    
    /// <summary>
    /// Magnetic Ink Character Recognition, using the E-13B font) Line at the bottom of a check containing the bank account and the check number.
    /// Encoded/decoded by serializers as "E13B".
    /// </summary>
    [EnumMember(Value = "E13B")]
    [IsoId("_qGWeYNkWEeiojJsa6FYyew")]
    [Description(@"Magnetic Ink Character Recognition, using the E-13B font) Line at the bottom of a check containing the bank account and the check number.")]
    E13BCheckFormat,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TrackFormatCodeMetadataExtensions
{
    private static readonly TrackFormatCodeDropdownSource _dropdownSource = new TrackFormatCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITrackFormatCodeDropdownRow GetMetadata(this TrackFormatCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



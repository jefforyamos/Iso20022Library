﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PINFormat1Code.  ISO2002 ID# _TTtRTAEcEeCQm6a_G2yO_w_553869371.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// PIN (Personal Identification Number) format used to encrypt the PIN block.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_TTtRTAEcEeCQm6a_G2yO_w_553869371")]
[Description(@"PIN (Personal Identification Number) format used to encrypt the PIN block.")]
[DerivedFrom(typeof(PINFormatCode))]
public enum PINFormat1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO0".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TTtRTQEcEeCQm6a_G2yO_w_-36231100")]
    [Description(@"??")]
    ISO0,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO1".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TTtRTgEcEeCQm6a_G2yO_w_325809407")]
    [Description(@"??")]
    ISO1,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO2".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TTtRTwEcEeCQm6a_G2yO_w_-1049115605")]
    [Description(@"??")]
    ISO2,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "ISO3".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_TTtRUAEcEeCQm6a_G2yO_w_888109568")]
    [Description(@"??")]
    ISO3,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PINFormat1CodeMetadataExtensions
{
    private static readonly PINFormat1CodeDropdownSource _dropdownSource = new PINFormat1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPINFormat1CodeDropdownRow GetMetadata(this PINFormat1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


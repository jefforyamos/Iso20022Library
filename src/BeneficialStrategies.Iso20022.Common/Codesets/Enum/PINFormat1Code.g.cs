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
    /// PIN diversified with the card account number, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as "ISO0".
    /// </summary>
    [EnumMember(Value = "ISO0")]
    [IsoId("_TTtRTQEcEeCQm6a_G2yO_w_-36231100")]
    [Description(@"PIN diversified with the card account number, conforming to the standard ISO 9564-2.")]
    ISO0,
    
    /// <summary>
    /// PIN completed with random padding characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as "ISO1".
    /// </summary>
    [EnumMember(Value = "ISO1")]
    [IsoId("_TTtRTgEcEeCQm6a_G2yO_w_325809407")]
    [Description(@"PIN completed with random padding characters, conforming to the standard ISO 9564-2.")]
    ISO1,
    
    /// <summary>
    /// PIN without diversification characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as "ISO2".
    /// </summary>
    [EnumMember(Value = "ISO2")]
    [IsoId("_TTtRTwEcEeCQm6a_G2yO_w_-1049115605")]
    [Description(@"PIN without diversification characters, conforming to the standard ISO 9564-2.")]
    ISO2,
    
    /// <summary>
    /// PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2.
    /// Encoded/decoded by serializers as "ISO3".
    /// </summary>
    [EnumMember(Value = "ISO3")]
    [IsoId("_TTtRUAEcEeCQm6a_G2yO_w_888109568")]
    [Description(@"PIN diversified with the card account number and random characters, conforming to the standard ISO 9564-2.")]
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



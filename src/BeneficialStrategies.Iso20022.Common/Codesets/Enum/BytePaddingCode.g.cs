﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BytePaddingCode.  ISO2002 ID# _NOnpUGi9EeS87LmvcA55sg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_NOnpUGi9EeS87LmvcA55sg")]
[Description(@"Byte padding for a cypher block chaining mode encryption, if the padding is not implicit.")]
[Derivations(typeof(BytePadding1Code))]
// External derivations that should be provided by the proper interface are: 
public enum BytePaddingCode
{
    /// <summary>
    /// Message to encrypt is completed by a byte value containing the total number of added bytes.
    /// Encoded/decoded by serializers as "LNGT".
    /// </summary>
    [EnumMember(Value = "LNGT")]
    [IsoId("_SKu-AGi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by a byte value containing the total number of added bytes.")]
    LengthPadding,
    
    /// <summary>
    /// Message to encrypt is completed by one bit of value 1, followed by null bits until the encryption block length is reached.
    /// Encoded/decoded by serializers as "NUL8".
    /// </summary>
    [EnumMember(Value = "NUL8")]
    [IsoId("_XA738Gi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by one bit of value 1, followed by null bits until the encryption block length is reached.")]
    Null80Padding,
    
    /// <summary>
    /// Message to encrypt is completed by null byte values, the last byte containing the total number of added bytes.
    /// Encoded/decoded by serializers as "NULG".
    /// </summary>
    [EnumMember(Value = "NULG")]
    [IsoId("_bkh-8Gi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by null byte values, the last byte containing the total number of added bytes.")]
    NullLengthPadding,
    
    /// <summary>
    /// Message to encrypt is completed by null bytes.
    /// Encoded/decoded by serializers as "NULL".
    /// </summary>
    [EnumMember(Value = "NULL")]
    [IsoId("_lAGhgGi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by null bytes.")]
    NullPadding,
    
    /// <summary>
    /// Message to encrypt is completed by random value, the last byte containing the total number of added bytes.
    /// Encoded/decoded by serializers as "RAND".
    /// </summary>
    [EnumMember(Value = "RAND")]
    [IsoId("_pMu6AGi9EeS87LmvcA55sg")]
    [Description(@"Message to encrypt is completed by random value, the last byte containing the total number of added bytes.")]
    RandomPadding,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BytePaddingCodeMetadataExtensions
{
    private static readonly BytePaddingCodeDropdownSource _dropdownSource = new BytePaddingCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBytePaddingCodeDropdownRow GetMetadata(this BytePaddingCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



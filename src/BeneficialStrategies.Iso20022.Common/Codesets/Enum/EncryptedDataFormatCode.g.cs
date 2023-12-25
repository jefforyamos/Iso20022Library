﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EncryptedDataFormatCode.  ISO2002 ID# _lupawAHwEeiJObvChJn-OA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Format used to encrypt the data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lupawAHwEeiJObvChJn-OA")]
[Description(@"Format used to encrypt the data.")]
public enum EncryptedDataFormatCode
{
    /// <summary>
    /// ASCII Format.
    /// </summary>
    [EnumMember(Value = "ASCI")]
    [IsoId("_xUSBIAHwEeiJObvChJn-OA")]
    [Description(@"ASCII Format.")]
    ASCI,
    
    /// <summary>
    /// HEX Format.
    /// </summary>
    [EnumMember(Value = "HEXF")]
    [IsoId("_33X6sAHwEeiJObvChJn-OA")]
    [Description(@"HEX Format.")]
    HEXF,
    
    /// <summary>
    /// Binary format.
    /// </summary>
    [EnumMember(Value = "BINF")]
    [IsoId("_FUVPEAHxEeiJObvChJn-OA")]
    [Description(@"Binary format.")]
    BINF,
    
    /// <summary>
    /// Other format defined at national level.
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_VyY88AHxEeiJObvChJn-OA")]
    [Description(@"Other format defined at national level.")]
    OTHN,
    
    /// <summary>
    /// Other type of format defined at private level.
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_a5ZTAAHxEeiJObvChJn-OA")]
    [Description(@"Other type of format defined at private level.")]
    OTHP,
    
    /// <summary>
    /// EBCDIC format.
    /// </summary>
    [EnumMember(Value = "EBCD")]
    [IsoId("_V0-sAAHzEeiJObvChJn-OA")]
    [Description(@"EBCDIC format.")]
    EBCD,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EncryptedDataFormatCodeMetadataExtensions
{
    private static readonly EncryptedDataFormatCodeDropdownSource _dropdownSource = new EncryptedDataFormatCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEncryptedDataFormatCodeDropdownRow GetMetadata(this EncryptedDataFormatCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



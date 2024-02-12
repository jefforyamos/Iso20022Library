﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EncryptedDataFormatCode.  ISO2002 ID# _lupawAHwEeiJObvChJn-OA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Format used to encrypt the data.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lupawAHwEeiJObvChJn-OA")]
[Description(@"Format used to encrypt the data.")]
[Derivations(typeof(EncryptedDataFormat1Code))]
public enum EncryptedDataFormatCode
{
    /// <summary>
    /// ASCII Format.
    /// Encoded/decoded by serializers as "ASCI".
    /// </summary>
    [EnumMember(Value = "ASCI")]
    [IsoId("_xUSBIAHwEeiJObvChJn-OA")]
    [Description(@"ASCII Format.")]
    ASCII,
    
    /// <summary>
    /// HEX Format.
    /// Encoded/decoded by serializers as "HEXF".
    /// </summary>
    [EnumMember(Value = "HEXF")]
    [IsoId("_33X6sAHwEeiJObvChJn-OA")]
    [Description(@"HEX Format.")]
    HEX,
    
    /// <summary>
    /// Binary format.
    /// Encoded/decoded by serializers as "BINF".
    /// </summary>
    [EnumMember(Value = "BINF")]
    [IsoId("_FUVPEAHxEeiJObvChJn-OA")]
    [Description(@"Binary format.")]
    Binary,
    
    /// <summary>
    /// Other format defined at national level.
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_VyY88AHxEeiJObvChJn-OA")]
    [Description(@"Other format defined at national level.")]
    OtherNational,
    
    /// <summary>
    /// Other type of format defined at private level.
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_a5ZTAAHxEeiJObvChJn-OA")]
    [Description(@"Other type of format defined at private level.")]
    OtherPrivate,
    
    /// <summary>
    /// EBCDIC format.
    /// Encoded/decoded by serializers as "EBCD".
    /// </summary>
    [EnumMember(Value = "EBCD")]
    [IsoId("_V0-sAAHzEeiJObvChJn-OA")]
    [Description(@"EBCDIC format.")]
    EBCDIC,
    
}

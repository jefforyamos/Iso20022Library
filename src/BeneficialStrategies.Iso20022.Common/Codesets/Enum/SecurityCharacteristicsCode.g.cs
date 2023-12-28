﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for SecurityCharacteristicsCode.  ISO2002 ID# _X8tNUEqzEeenp6hmNprBHg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Security characteristics of the communication link between a cardholder and a card acceptor.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_X8tNUEqzEeenp6hmNprBHg")]
[Description(@"Security characteristics of the communication link between a cardholder and a card acceptor.")]
public enum SecurityCharacteristicsCode
{
    /// <summary>
    /// Private network.
    /// Encoded/decoded by serializers as "PRVN".
    /// </summary>
    [EnumMember(Value = "PRVN")]
    [IsoId("_g_y-cEqzEeenp6hmNprBHg")]
    [Description(@"Private network.")]
    PrivateNetwork,
    
    /// <summary>
    /// Open network
    /// Encoded/decoded by serializers as "OPNN".
    /// </summary>
    [EnumMember(Value = "OPNN")]
    [IsoId("_oj8FUEqzEeenp6hmNprBHg")]
    [Description(@"Open network")]
    OpenNetwork,
    
    /// <summary>
    /// Usage of MAC to secure a communication channel
    /// Encoded/decoded by serializers as "CMAC".
    /// </summary>
    [EnumMember(Value = "CMAC")]
    [IsoId("_sG2ycEqzEeenp6hmNprBHg")]
    [Description(@"Usage of MAC to secure a communication channel")]
    ChannelMAC,
    
    /// <summary>
    /// MAC used in a pass-through communication mode
    /// Encoded/decoded by serializers as "PMAC".
    /// </summary>
    [EnumMember(Value = "PMAC")]
    [IsoId("_1EVDwEqzEeenp6hmNprBHg")]
    [Description(@"MAC used in a pass-through communication mode")]
    PassthroughMAC,
    
    /// <summary>
    /// Encryption used from one end to the other end of the communication channel.
    /// Encoded/decoded by serializers as "ETEE".
    /// </summary>
    [EnumMember(Value = "ETEE")]
    [IsoId("_-f9QsEqzEeenp6hmNprBHg")]
    [Description(@"Encryption used from one end to the other end of the communication channel.")]
    EndToEndEncryption,
    
    /// <summary>
    /// Encryption used to secure the communication channel.
    /// Encoded/decoded by serializers as "CENC".
    /// </summary>
    [EnumMember(Value = "CENC")]
    [IsoId("_AOq1QEq0Eeenp6hmNprBHg")]
    [Description(@"Encryption used to secure the communication channel.")]
    ChannelEncryption,
    
    /// <summary>
    /// Encryption using a private algorithm to secure a communication channel.
    /// Encoded/decoded by serializers as "PRAE".
    /// </summary>
    [EnumMember(Value = "PRAE")]
    [IsoId("_WeDokEq0Eeenp6hmNprBHg")]
    [Description(@"Encryption using a private algorithm to secure a communication channel.")]
    PrivateAlgorithmEncryption,
    
    /// <summary>
    /// Encryption using PKI to secure the communication channel.
    /// Encoded/decoded by serializers as "PKIE".
    /// </summary>
    [EnumMember(Value = "PKIE")]
    [IsoId("_fNZ-UEq0Eeenp6hmNprBHg")]
    [Description(@"Encryption using PKI to secure the communication channel.")]
    PKIEncryption,
    
    /// <summary>
    /// Private algorithm used for MAC.
    /// Encoded/decoded by serializers as "PRAM".
    /// </summary>
    [EnumMember(Value = "PRAM")]
    [IsoId("_kp74cEq0Eeenp6hmNprBHg")]
    [Description(@"Private algorithm used for MAC.")]
    PrivateAlgorithmMAC,
    
    /// <summary>
    /// Standard algorithm used for MAC
    /// Encoded/decoded by serializers as "STAM".
    /// </summary>
    [EnumMember(Value = "STAM")]
    [IsoId("_w9ZOIEq0Eeenp6hmNprBHg")]
    [Description(@"Standard algorithm used for MAC")]
    StandardAlgorithmMAC,
    
    /// <summary>
    /// Encryption initiated by the cardholder to secure end-to-end communication channel.
    /// Encoded/decoded by serializers as "CETE".
    /// </summary>
    [EnumMember(Value = "CETE")]
    [IsoId("_5JXKAEq0Eeenp6hmNprBHg")]
    [Description(@"Encryption initiated by the cardholder to secure end-to-end communication channel.")]
    CardholderEndToEndEncryption,
    
    /// <summary>
    /// Encryption initiated by the cardholder to secure point-to-point communication channel.
    /// Encoded/decoded by serializers as "CPTE".
    /// </summary>
    [EnumMember(Value = "CPTE")]
    [IsoId("_IMrYMEq1Eeenp6hmNprBHg")]
    [Description(@"Encryption initiated by the cardholder to secure point-to-point communication channel.")]
    CardholderPointToPointEncryption,
    
    /// <summary>
    /// Encryption initiated by the merchant to secure end-to-end communication channel.
    /// Encoded/decoded by serializers as "METE".
    /// </summary>
    [EnumMember(Value = "METE")]
    [IsoId("_VEq-UEq1Eeenp6hmNprBHg")]
    [Description(@"Encryption initiated by the merchant to secure end-to-end communication channel.")]
    MerchantEndToEndEncryption,
    
    /// <summary>
    /// Encryption initiated by the merchant to secure point-to-point communication channel.
    /// Encoded/decoded by serializers as "MPTE".
    /// </summary>
    [EnumMember(Value = "MPTE")]
    [IsoId("_cKz6kEq1Eeenp6hmNprBHg")]
    [Description(@"Encryption initiated by the merchant to secure point-to-point communication channel.")]
    MerchantPointToPointEncryption,
    
    /// <summary>
    /// Encryption initiated by the acquirer to secure end-to-end communication channel.
    /// Encoded/decoded by serializers as "AETE".
    /// </summary>
    [EnumMember(Value = "AETE")]
    [IsoId("_mvjrsEq1Eeenp6hmNprBHg")]
    [Description(@"Encryption initiated by the acquirer to secure end-to-end communication channel.")]
    AcquirerEndToEndEncryption,
    
    /// <summary>
    /// Encryption initiated by the acquirer to secure point-to-point communication channel.
    /// Encoded/decoded by serializers as "APTE".
    /// </summary>
    [EnumMember(Value = "APTE")]
    [IsoId("_tBuNUEq1Eeenp6hmNprBHg")]
    [Description(@"Encryption initiated by the acquirer to secure point-to-point communication channel.")]
    AcquirerPointToPointEncryption,
    
    /// <summary>
    /// Other security characteristics defined at national level
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_7qoHQAwfEeiHgJ0O2VQ-kg")]
    [Description(@"Other security characteristics defined at national level")]
    OtherNational,
    
    /// <summary>
    /// Other security characteristics defined at private level
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_CwUXkAwgEeiHgJ0O2VQ-kg")]
    [Description(@"Other security characteristics defined at private level")]
    OtherPrivate,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class SecurityCharacteristicsCodeMetadataExtensions
{
    private static readonly SecurityCharacteristicsCodeDropdownSource _dropdownSource = new SecurityCharacteristicsCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ISecurityCharacteristicsCodeDropdownRow GetMetadata(this SecurityCharacteristicsCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


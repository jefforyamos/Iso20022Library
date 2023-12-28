﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TelephonyCallType1Code.  ISO2002 ID# _YOAJsDEvEemzCpWiCwK4aQ.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the call type
/// </summary>
[DataContract]
[Serializable]
[IsoId("_YOAJsDEvEemzCpWiCwK4aQ")]
[Description(@"Indicates the call type")]
[DerivedFrom(typeof(TelephonyCallTypeCode))]
public enum TelephonyCallType1Code
{
    /// <summary>
    /// Voice mail
    /// Encoded/decoded by serializers as "VoiceMail".
    /// </summary>
    [EnumMember(Value = "VCML")]
    [IsoId("_caQHsTEvEemzCpWiCwK4aQ")]
    [Description(@"Voice mail")]
    VoiceMail,
    
    /// <summary>
    /// Toll free phone call
    /// Encoded/decoded by serializers as "TollFreeCall".
    /// </summary>
    [EnumMember(Value = "TFPC")]
    [IsoId("_cuX9kTEvEemzCpWiCwK4aQ")]
    [Description(@"Toll free phone call")]
    TollFreeCall,
    
    /// <summary>
    /// Page
    /// Encoded/decoded by serializers as "Page".
    /// </summary>
    [EnumMember(Value = "PAGE")]
    [IsoId("_c1-aYTEvEemzCpWiCwK4aQ")]
    [Description(@"Page")]
    Page,
    
    /// <summary>
    /// Outgoing phone call
    /// Encoded/decoded by serializers as "OutgoingCall".
    /// </summary>
    [EnumMember(Value = "OGPC")]
    [IsoId("_dFeO8TEvEemzCpWiCwK4aQ")]
    [Description(@"Outgoing phone call")]
    OutgoingCall,
    
    /// <summary>
    /// Other private
    /// Encoded/decoded by serializers as "OtherPrivate".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("_dGXm0TEvEemzCpWiCwK4aQ")]
    [Description(@"Other private")]
    OtherPrivate,
    
    /// <summary>
    /// Other national
    /// Encoded/decoded by serializers as "OtherNational".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("_degaATEvEemzCpWiCwK4aQ")]
    [Description(@"Other national")]
    OtherNational,
    
    /// <summary>
    /// Other type of call not elsewhere classified. 
    /// Encoded/decoded by serializers as "Other".
    /// </summary>
    [EnumMember(Value = "OTCL")]
    [IsoId("_dhMhoTEvEemzCpWiCwK4aQ")]
    [Description(@"Other type of call not elsewhere classified. ")]
    Other,
    
    /// <summary>
    /// Incoming phone call
    /// Encoded/decoded by serializers as "IncomingCall".
    /// </summary>
    [EnumMember(Value = "ICPC")]
    [IsoId("_d28vMTEvEemzCpWiCwK4aQ")]
    [Description(@"Incoming phone call")]
    IncomingCall,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TelephonyCallType1CodeMetadataExtensions
{
    private static readonly TelephonyCallType1CodeDropdownSource _dropdownSource = new TelephonyCallType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITelephonyCallType1CodeDropdownRow GetMetadata(this TelephonyCallType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



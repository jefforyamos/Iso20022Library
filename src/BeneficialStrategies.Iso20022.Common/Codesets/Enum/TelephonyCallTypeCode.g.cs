﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for TelephonyCallTypeCode.  ISO2002 ID# __R_VYPfFEei89sMSHxl1ew.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the call type
/// </summary>
[DataContract]
[Serializable]
[IsoId("__R_VYPfFEei89sMSHxl1ew")]
[Description(@"Indicates the call type")]
[Derivations(typeof(TelephonyCallType1Code))]
public enum TelephonyCallTypeCode
{
    /// <summary>
    /// Outgoing phone call
    /// Encoded/decoded by serializers as "OGPC".
    /// </summary>
    [EnumMember(Value = "OGPC")]
    [IsoId("__R_VY_fFEei89sMSHxl1ew")]
    [Description(@"Outgoing phone call")]
    OutgoingCall,
    
    /// <summary>
    /// Voice mail
    /// Encoded/decoded by serializers as "VCML".
    /// </summary>
    [EnumMember(Value = "VCML")]
    [IsoId("__R_VZvfFEei89sMSHxl1ew")]
    [Description(@"Voice mail")]
    VoiceMail,
    
    /// <summary>
    /// Incoming phone call
    /// Encoded/decoded by serializers as "ICPC".
    /// </summary>
    [EnumMember(Value = "ICPC")]
    [IsoId("__R_VZffFEei89sMSHxl1ew")]
    [Description(@"Incoming phone call")]
    IncomingCall,
    
    /// <summary>
    /// Page
    /// Encoded/decoded by serializers as "PAGE".
    /// </summary>
    [EnumMember(Value = "PAGE")]
    [IsoId("__R_VYffFEei89sMSHxl1ew")]
    [Description(@"Page")]
    Page,
    
    /// <summary>
    /// Other national
    /// Encoded/decoded by serializers as "OTHN".
    /// </summary>
    [EnumMember(Value = "OTHN")]
    [IsoId("__R_VYvfFEei89sMSHxl1ew")]
    [Description(@"Other national")]
    OtherNational,
    
    /// <summary>
    /// Other private
    /// Encoded/decoded by serializers as "OTHP".
    /// </summary>
    [EnumMember(Value = "OTHP")]
    [IsoId("__R_VZPfFEei89sMSHxl1ew")]
    [Description(@"Other private")]
    OtherPrivate,
    
    /// <summary>
    /// Toll free phone call
    /// Encoded/decoded by serializers as "TFPC".
    /// </summary>
    [EnumMember(Value = "TFPC")]
    [IsoId("_g5PY0PfGEei89sMSHxl1ew")]
    [Description(@"Toll free phone call")]
    TollFreeCall,
    
    /// <summary>
    /// Other type of call not elsewhere classified. 
    /// Encoded/decoded by serializers as "OTCL".
    /// </summary>
    [EnumMember(Value = "OTCL")]
    [IsoId("_oUNVkPfGEei89sMSHxl1ew")]
    [Description(@"Other type of call not elsewhere classified. ")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class TelephonyCallTypeCodeMetadataExtensions
{
    private static readonly TelephonyCallTypeCodeDropdownSource _dropdownSource = new TelephonyCallTypeCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ITelephonyCallTypeCodeDropdownRow GetMetadata(this TelephonyCallTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EnergyLoadTypeCode.  ISO2002 ID# _uODncBVnEeWXLoZC9OIRgg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the energy delivery profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_uODncBVnEeWXLoZC9OIRgg")]
[Description(@"Specifies the energy delivery profile.")]
public enum EnergyLoadTypeCode
{
    /// <summary>
    /// Off-Peak.
    /// 
    /// Encoded/decoded by serializers as "OFFP".
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_0JbZsBVnEeWXLoZC9OIRgg")]
    [Description(@"Off-Peak. ")]
    Off_Peak,
    
    /// <summary>
    /// Hour and block hours.
    /// Encoded/decoded by serializers as "HABH".
    /// </summary>
    [EnumMember(Value = "HABH")]
    [IsoId("_0NmIABVnEeWXLoZC9OIRgg")]
    [Description(@"Hour and block hours.")]
    HourAndBlockHours,
    
    /// <summary>
    /// Shaped.
    /// Encoded/decoded by serializers as "SHPD".
    /// </summary>
    [EnumMember(Value = "SHPD")]
    [IsoId("_0Rw2UBVnEeWXLoZC9OIRgg")]
    [Description(@"Shaped.")]
    Shaped,
    
    /// <summary>
    /// Gas day.
    /// Encoded/decoded by serializers as "GASD".
    /// </summary>
    [EnumMember(Value = "GASD")]
    [IsoId("_0Rw2URVnEeWXLoZC9OIRgg")]
    [Description(@"Gas day.")]
    GasDay,
    
    /// <summary>
    /// Base load.
    /// Encoded/decoded by serializers as "BSLD".
    /// </summary>
    [EnumMember(Value = "BSLD")]
    [IsoId("_EmqBIhVoEeWXLoZC9OIRgg")]
    [Description(@"Base load.")]
    BaseLoad,
    
    /// <summary>
    /// Peak load.
    /// Encoded/decoded by serializers as "PKLD".
    /// </summary>
    [EnumMember(Value = "PKLD")]
    [IsoId("_EmqBIxVoEeWXLoZC9OIRgg")]
    [Description(@"Peak load.")]
    PeakLoad,
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_jP73kBVoEeWXLoZC9OIRgg")]
    [Description(@"Other.")]
    Other,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EnergyLoadTypeCodeMetadataExtensions
{
    private static readonly EnergyLoadTypeCodeDropdownSource _dropdownSource = new EnergyLoadTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEnergyLoadTypeCodeDropdownRow GetMetadata(this EnergyLoadTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



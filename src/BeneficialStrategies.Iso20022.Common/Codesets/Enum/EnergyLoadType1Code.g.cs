﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for EnergyLoadType1Code.  ISO2002 ID# _ohWt4BVoEeWXLoZC9OIRgg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the energy delivery profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ohWt4BVoEeWXLoZC9OIRgg")]
[Description(@"Specifies the energy delivery profile.")]
[DerivedFrom(typeof(EnergyLoadTypeCode))]
public enum EnergyLoadType1Code
{
    /// <summary>
    /// Base load.
    /// Encoded/decoded by serializers as "BSLD".
    /// </summary>
    [EnumMember(Value = "BSLD")]
    [IsoId("_rT4f4RVoEeWXLoZC9OIRgg")]
    [Description(@"Base load.")]
    BaseLoad = EnergyLoadTypeCode.BaseLoad, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Gas day.
    /// Encoded/decoded by serializers as "GASD".
    /// </summary>
    [EnumMember(Value = "GASD")]
    [IsoId("_rf7X0RVoEeWXLoZC9OIRgg")]
    [Description(@"Gas day.")]
    GasDay = EnergyLoadTypeCode.GasDay, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Hour and block hours.
    /// Encoded/decoded by serializers as "HABH".
    /// </summary>
    [EnumMember(Value = "HABH")]
    [IsoId("_rsRxwRVoEeWXLoZC9OIRgg")]
    [Description(@"Hour and block hours.")]
    HourAndBlockHours = EnergyLoadTypeCode.HourAndBlockHours, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Off-Peak.
    /// Encoded/decoded by serializers as "OFFP".
    /// </summary>
    [EnumMember(Value = "OFFP")]
    [IsoId("_r4VQwRVoEeWXLoZC9OIRgg")]
    [Description(@"Off-Peak.|")]
    Off_Peak = EnergyLoadTypeCode.Off_Peak, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Other.
    /// Encoded/decoded by serializers as "OTHR".
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_sEYIsRVoEeWXLoZC9OIRgg")]
    [Description(@"Other.")]
    Other = EnergyLoadTypeCode.Other, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Peak load.
    /// Encoded/decoded by serializers as "PKLD".
    /// </summary>
    [EnumMember(Value = "PKLD")]
    [IsoId("_sQbnsRVoEeWXLoZC9OIRgg")]
    [Description(@"Peak load.")]
    PeakLoad = EnergyLoadTypeCode.PeakLoad, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Shaped.
    /// Encoded/decoded by serializers as "SHPD".
    /// </summary>
    [EnumMember(Value = "SHPD")]
    [IsoId("_scVVsRVoEeWXLoZC9OIRgg")]
    [Description(@"Shaped.")]
    Shaped = EnergyLoadTypeCode.Shaped, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class EnergyLoadType1CodeMetadataExtensions
{
    private static readonly EnergyLoadType1CodeDropdownSource _dropdownSource = new EnergyLoadType1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IEnergyLoadType1CodeDropdownRow GetMetadata(this EnergyLoadType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



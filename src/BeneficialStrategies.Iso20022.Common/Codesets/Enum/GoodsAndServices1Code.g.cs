﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for GoodsAndServices1Code.  ISO2002 ID# _XQ414ErDEeenp6hmNprBHg.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Type of goods and services purchased.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_XQ414ErDEeenp6hmNprBHg")]
[Description(@"Type of goods and services purchased.")]
[DerivedFrom(typeof(GoodsAndServicesCode))]
public enum GoodsAndServices1Code
{
    /// <summary>
    /// Electronic goods and services.
    /// Encoded/decoded by serializers as "Electronic".
    /// </summary>
    [EnumMember(Value = "ELEC")]
    [IsoId("_cGi64VHiEeeJoafcMZup1w")]
    [Description(@"Electronic goods and services.")]
    Electronic,
    
    /// <summary>
    /// Physical goods or services.
    /// Encoded/decoded by serializers as "Physical".
    /// </summary>
    [EnumMember(Value = "PHYS")]
    [IsoId("_cTo7sVHiEeeJoafcMZup1w")]
    [Description(@"Physical goods or services.")]
    Physical,
    
    /// <summary>
    /// Electronic and physical goods and services.
    /// Encoded/decoded by serializers as "ElectronicAndPhysical".
    /// </summary>
    [EnumMember(Value = "ELPH")]
    [IsoId("_cjQsEVHiEeeJoafcMZup1w")]
    [Description(@"Electronic and physical goods and services.")]
    ElectronicAndPhysical,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class GoodsAndServices1CodeMetadataExtensions
{
    private static readonly GoodsAndServices1CodeDropdownSource _dropdownSource = new GoodsAndServices1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IGoodsAndServices1CodeDropdownRow GetMetadata(this GoodsAndServices1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



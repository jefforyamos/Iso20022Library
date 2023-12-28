﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for ProfileType1Code.  ISO2002 ID# _LGXUsCGLEeW_v8XsK-l3KA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of profile.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_LGXUsCGLEeW_v8XsK-l3KA")]
[Description(@"Specifies the type of profile.")]
[DerivedFrom(typeof(ProfileTypeCode))]
public enum ProfileType1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Hedge".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_N0lOcSGLEeW_v8XsK-l3KA")]
    [Description(@"??")]
    Hedge,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "HighFrequencyTrader".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_N8nJESGLEeW_v8XsK-l3KA")]
    [Description(@"??")]
    HighFrequencyTrader,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MarketMaker".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_OEpDsSGLEeW_v8XsK-l3KA")]
    [Description(@"??")]
    MarketMaker,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Treasury".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_OMrlYSGLEeW_v8XsK-l3KA")]
    [Description(@"??")]
    Treasury,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class ProfileType1CodeMetadataExtensions
{
    private static readonly ProfileType1CodeDropdownSource _dropdownSource = new ProfileType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IProfileType1CodeDropdownRow GetMetadata(this ProfileType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for PreAllocationMethodCode.  ISO2002 ID# _aH73WNp-Ed-ak6NoX_4Aeg_616932935.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the method of preallocation.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aH73WNp-Ed-ak6NoX_4Aeg_616932935")]
[Description(@"Indicates the method of preallocation.")]
[Derivations(typeof(PreAllocationMethod1Code))]
public enum PreAllocationMethodCode
{
    /// <summary>
    /// Preallocation is proratised.
    /// Encoded/decoded by serializers as "PROR".
    /// </summary>
    [EnumMember(Value = "PROR")]
    [IsoId("_aIFoUNp-Ed-ak6NoX_4Aeg_643714948")]
    [Description(@"Preallocation is proratised.")]
    Prorata,
    
    /// <summary>
    /// No prorata, discuss first.
    /// Encoded/decoded by serializers as "TALK".
    /// </summary>
    [EnumMember(Value = "TALK")]
    [IsoId("_aIFoUdp-Ed-ak6NoX_4Aeg_1099009423")]
    [Description(@"No prorata, discuss first.")]
    SpeakFirst,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class PreAllocationMethodCodeMetadataExtensions
{
    private static readonly PreAllocationMethodCodeDropdownSource _dropdownSource = new PreAllocationMethodCodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IPreAllocationMethodCodeDropdownRow GetMetadata(this PreAllocationMethodCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



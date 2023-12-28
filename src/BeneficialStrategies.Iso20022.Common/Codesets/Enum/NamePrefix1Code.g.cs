﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for NamePrefix1Code.  ISO2002 ID# _aM_9hNp-Ed-ak6NoX_4Aeg_1660850708.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the terms used to formally address a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aM_9hNp-Ed-ak6NoX_4Aeg_1660850708")]
[Description(@"Specifies the terms used to formally address a person.")]
[DerivedFrom(typeof(NamePrefixCode))]
public enum NamePrefix1Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Doctor".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jXsywYc0EeeO5vQpPey46w")]
    [Description(@"??")]
    Doctor,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Mister".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jp59EYc0EeeO5vQpPey46w")]
    [Description(@"??")]
    Mister,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Miss".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jkbAIYc0EeeO5vQpPey46w")]
    [Description(@"??")]
    Miss,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Madam".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_jehMcYc0EeeO5vQpPey46w")]
    [Description(@"??")]
    Madam,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class NamePrefix1CodeMetadataExtensions
{
    private static readonly NamePrefix1CodeDropdownSource _dropdownSource = new NamePrefix1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static INamePrefix1CodeDropdownRow GetMetadata(this NamePrefix1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


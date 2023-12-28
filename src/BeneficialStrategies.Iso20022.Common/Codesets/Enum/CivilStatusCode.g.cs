﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for CivilStatusCode.  ISO2002 ID# _Dog4YCChEeWJd9HF2tO7BA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the civil status of a person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_Dog4YCChEeWJd9HF2tO7BA")]
[Description(@"Specifies the civil status of a person.")]
public enum CivilStatusCode
{
    /// <summary>
    /// Person is single.
    /// Encoded/decoded by serializers as "SING".
    /// </summary>
    [EnumMember(Value = "SING")]
    [IsoId("_L0NugCChEeWJd9HF2tO7BA")]
    [Description(@"Person is single.")]
    Single,
    
    /// <summary>
    /// Person is married.
    /// Encoded/decoded by serializers as "MARR".
    /// </summary>
    [EnumMember(Value = "MARR")]
    [IsoId("_POxw4CChEeWJd9HF2tO7BA")]
    [Description(@"Person is married.")]
    Married,
    
    /// <summary>
    /// Person is legally divorced.
    /// Encoded/decoded by serializers as "LDIV".
    /// </summary>
    [EnumMember(Value = "LDIV")]
    [IsoId("_SKFrcCChEeWJd9HF2tO7BA")]
    [Description(@"Person is legally divorced.")]
    LegallyDivorced,
    
    /// <summary>
    /// Person is divorced.
    /// Encoded/decoded by serializers as "DIVO".
    /// </summary>
    [EnumMember(Value = "DIVO")]
    [IsoId("_WeEpICChEeWJd9HF2tO7BA")]
    [Description(@"Person is divorced.")]
    Divorced,
    
    /// <summary>
    /// Person is a widower.
    /// Encoded/decoded by serializers as "WIDO".
    /// </summary>
    [EnumMember(Value = "WIDO")]
    [IsoId("_cXFD4CChEeWJd9HF2tO7BA")]
    [Description(@"Person is a widower.")]
    Widow,
    
    /// <summary>
    /// Person is in a stable union.
    /// Encoded/decoded by serializers as "UNIO".
    /// </summary>
    [EnumMember(Value = "UNIO")]
    [IsoId("_hRvnECChEeWJd9HF2tO7BA")]
    [Description(@"Person is in a stable union.")]
    StableUnion,
    
    /// <summary>
    /// Person is separated.
    /// Encoded/decoded by serializers as "SEPA".
    /// </summary>
    [EnumMember(Value = "SEPA")]
    [IsoId("_kwBEwCChEeWJd9HF2tO7BA")]
    [Description(@"Person is separated.")]
    Separated,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class CivilStatusCodeMetadataExtensions
{
    private static readonly CivilStatusCodeDropdownSource _dropdownSource = new CivilStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static ICivilStatusCodeDropdownRow GetMetadata(this CivilStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



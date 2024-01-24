﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MemberStatus1Code.  ISO2002 ID# _zdmYYw93EeGeV5vP7Mvdig_311511603.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the live status of a member of a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_zdmYYw93EeGeV5vP7Mvdig_311511603")]
[Description(@"Specifies the live status of a member of a system.")]
[DerivedFrom(typeof(MemberStatusCode))]
public enum MemberStatus1Code
{
    /// <summary>
    /// Member is live on the system.
    /// Encoded/decoded by serializers as "ENBL".
    /// </summary>
    [EnumMember(Value = "ENBL")]
    [IsoId("_zdmYZA93EeGeV5vP7Mvdig_-507442078")]
    [Description(@"Member is live on the system.")]
    Enabled = MemberStatusCode.Enabled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member is temporarily not live on the system.
    /// Encoded/decoded by serializers as "DSBL".
    /// </summary>
    [EnumMember(Value = "DSBL")]
    [IsoId("_zdmYZQ93EeGeV5vP7Mvdig_943717544")]
    [Description(@"Member is temporarily not live on the system.")]
    Disabled = MemberStatusCode.Disabled, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member is no longer live on the system.
    /// Encoded/decoded by serializers as "DLTD".
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_zdmYZg93EeGeV5vP7Mvdig_1865880854")]
    [Description(@"Member is no longer live on the system.")]
    Deleted = MemberStatusCode.Deleted, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Member is joining and will soon be enabled on the system.
    /// Encoded/decoded by serializers as "JOIN".
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_zdviUA93EeGeV5vP7Mvdig_1111130980")]
    [Description(@"Member is joining and will soon be enabled on the system.")]
    Joining = MemberStatusCode.Joining, // same ordinal as derivation source for type conversions
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MemberStatus1CodeMetadataExtensions
{
    private static readonly MemberStatus1CodeDropdownSource _dropdownSource = new MemberStatus1CodeDropdownSource();
    
    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMemberStatus1CodeDropdownRow GetMetadata(this MemberStatus1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



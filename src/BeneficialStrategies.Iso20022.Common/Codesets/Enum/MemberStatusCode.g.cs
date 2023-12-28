﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for MemberStatusCode.  ISO2002 ID# _aLqgwtp-Ed-ak6NoX_4Aeg_-1869032551.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the live status of a member of a system.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aLqgwtp-Ed-ak6NoX_4Aeg_-1869032551")]
[Description(@"Specifies the live status of a member of a system.")]
[Derivations(typeof(MemberStatus1Code))]
// External derivations that should be provided by the proper interface are: 
public enum MemberStatusCode
{
    /// <summary>
    /// Member is live on the system.
    /// Encoded/decoded by serializers as "ENBL".
    /// </summary>
    [EnumMember(Value = "ENBL")]
    [IsoId("_aLqgw9p-Ed-ak6NoX_4Aeg_-1869032550")]
    [Description(@"Member is live on the system.")]
    Enabled,
    
    /// <summary>
    /// Member is temporarily not live on the system.
    /// Encoded/decoded by serializers as "DSBL".
    /// </summary>
    [EnumMember(Value = "DSBL")]
    [IsoId("_aLqgxNp-Ed-ak6NoX_4Aeg_-1869032549")]
    [Description(@"Member is temporarily not live on the system.")]
    Disabled,
    
    /// <summary>
    /// Member is no longer live on the system.
    /// Encoded/decoded by serializers as "DLTD".
    /// </summary>
    [EnumMember(Value = "DLTD")]
    [IsoId("_aLqgxdp-Ed-ak6NoX_4Aeg_-1869032548")]
    [Description(@"Member is no longer live on the system.")]
    Deleted,
    
    /// <summary>
    /// Member is joining and will soon be enabled on the system.
    /// Encoded/decoded by serializers as "JOIN".
    /// </summary>
    [EnumMember(Value = "JOIN")]
    [IsoId("_aLqgxtp-Ed-ak6NoX_4Aeg_-1869032540")]
    [Description(@"Member is joining and will soon be enabled on the system.")]
    Joining,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class MemberStatusCodeMetadataExtensions
{
    private static readonly MemberStatusCodeDropdownSource _dropdownSource = new MemberStatusCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IMemberStatusCodeDropdownRow GetMetadata(this MemberStatusCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



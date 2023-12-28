﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BlockedReason2Code.  ISO2002 ID# _lXE7oFsMEeaY86V9afpFqA.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason an account is blocked.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_lXE7oFsMEeaY86V9afpFqA")]
[Description(@"Specifies the reason an account is blocked.")]
[DerivedFrom(typeof(BlockedReasonCode))]
public enum BlockedReason2Code
{
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Bankruptcy".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pAggcFsMEeaY86V9afpFqA")]
    [Description(@"??")]
    Bankruptcy,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Commitment".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pFkmoVsMEeaY86V9afpFqA")]
    [Description(@"??")]
    Commitment,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Confiscation".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pMHTgVsMEeaY86V9afpFqA")]
    [Description(@"??")]
    Confiscation,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "MortisCausa".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pSXFcVsMEeaY86V9afpFqA")]
    [Description(@"??")]
    MortisCausa,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "PendingComplianceVerification".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pZNUUVsMEeaY86V9afpFqA")]
    [Description(@"??")]
    PendingComplianceVerification,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Pledged".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pfdGQVsMEeaY86V9afpFqA")]
    [Description(@"??")]
    Pledged,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Reregistration".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pjxlkVsMEeaY86V9afpFqA")]
    [Description(@"??")]
    Reregistration,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Sanctions".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_poiJwVsMEeaY86V9afpFqA")]
    [Description(@"??")]
    Sanctions,
    
    /// <summary>
    /// ??
    /// Encoded/decoded by serializers as "Transfer".
    /// </summary>
    [EnumMember(Value = "")]
    [IsoId("_pvhikVsMEeaY86V9afpFqA")]
    [Description(@"??")]
    Transfer,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BlockedReason2CodeMetadataExtensions
{
    private static readonly BlockedReason2CodeDropdownSource _dropdownSource = new BlockedReason2CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBlockedReason2CodeDropdownRow GetMetadata(this BlockedReason2Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}


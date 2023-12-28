﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceAdjustmentTypeCode.  ISO2002 ID# _6URjCJqlEeGSON8vddiWzQ_-920501493.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of allowed balance adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6URjCJqlEeGSON8vddiWzQ_-920501493")]
[Description(@"Defines the type of allowed balance adjustment.")]
public enum BalanceAdjustmentTypeCode
{
    /// <summary>
    /// Adjustment applies to the average ledger (book) balance.
    /// Encoded/decoded by serializers as "LDGR".
    /// </summary>
    [EnumMember(Value = "LDGR")]
    [IsoId("_6Uas8JqlEeGSON8vddiWzQ_817535103")]
    [Description(@"Adjustment applies to the average ledger (book) balance.")]
    Ledger,
    
    /// <summary>
    /// Adjustment applies to the average float (unavailable) balance.
    /// Encoded/decoded by serializers as "FLOT".
    /// </summary>
    [EnumMember(Value = "FLOT")]
    [IsoId("_6Uas8ZqlEeGSON8vddiWzQ_1333312355")]
    [Description(@"Adjustment applies to the average float (unavailable) balance.")]
    Float,
    
    /// <summary>
    /// Adjustment applies to the average collected (book less float) balance.
    /// Encoded/decoded by serializers as "CLLD".
    /// </summary>
    [EnumMember(Value = "CLLD")]
    [IsoId("_6Uas8pqlEeGSON8vddiWzQ_-2029841198")]
    [Description(@"Adjustment applies to the average collected (book less float) balance.")]
    Collected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BalanceAdjustmentTypeCodeMetadataExtensions
{
    private static readonly BalanceAdjustmentTypeCodeDropdownSource _dropdownSource = new BalanceAdjustmentTypeCodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBalanceAdjustmentTypeCodeDropdownRow GetMetadata(this BalanceAdjustmentTypeCode code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



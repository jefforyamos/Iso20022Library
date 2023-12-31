﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by CodesetEnumGenerator for BalanceAdjustmentType1Code.  ISO2002 ID# _6URjBJqlEeGSON8vddiWzQ_7389297.
//

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines the type of allowed balance adjustment.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_6URjBJqlEeGSON8vddiWzQ_7389297")]
[Description(@"Defines the type of allowed balance adjustment.")]
[DerivedFrom(typeof(BalanceAdjustmentTypeCode))]
public enum BalanceAdjustmentType1Code
{
    /// <summary>
    /// Adjustment applies to the average ledger (book) balance.
    /// Encoded/decoded by serializers as "Ledger".
    /// </summary>
    [EnumMember(Value = "LDGR")]
    [IsoId("_6URjBZqlEeGSON8vddiWzQ_-1813350112")]
    [Description(@"Adjustment applies to the average ledger (book) balance.")]
    Ledger,
    
    /// <summary>
    /// Adjustment applies to the average float (unavailable) balance.
    /// Encoded/decoded by serializers as "Float".
    /// </summary>
    [EnumMember(Value = "FLOT")]
    [IsoId("_6URjBpqlEeGSON8vddiWzQ_-1052584959")]
    [Description(@"Adjustment applies to the average float (unavailable) balance.")]
    Float,
    
    /// <summary>
    /// Adjustment applies to the average collected (book less float) balance.
    /// Encoded/decoded by serializers as "Collected".
    /// </summary>
    [EnumMember(Value = "CLLD")]
    [IsoId("_6URjB5qlEeGSON8vddiWzQ_414563804")]
    [Description(@"Adjustment applies to the average collected (book less float) balance.")]
    Collected,
    
}


/// <summary>
/// Provides access to the metadata associated with a specific enum.
/// </summary>
public static class BalanceAdjustmentType1CodeMetadataExtensions
{
    private static readonly BalanceAdjustmentType1CodeDropdownSource _dropdownSource = new BalanceAdjustmentType1CodeDropdownSource();

    /// <summary>
    /// Returns the metadata associated with this enum value.
    /// </summary>
    public static IBalanceAdjustmentType1CodeDropdownRow GetMetadata(this BalanceAdjustmentType1Code code)
    {
        return _dropdownSource.Lookup(code) ;
    }
}



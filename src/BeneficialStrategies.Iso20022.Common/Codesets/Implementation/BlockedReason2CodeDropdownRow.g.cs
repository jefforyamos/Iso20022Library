﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BlockedReason2Code.  ISO2002 ID# _lXE7oFsMEeaY86V9afpFqA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason an account is blocked.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BlockedReason2CodeDropdownSource"/>.
/// Implements <seealso cref="IBlockedReason2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_lXE7oFsMEeaY86V9afpFqA")]
public partial class BlockedReason2CodeDropdownRow : EnumMetadataItem<BlockedReason2Code>, IBlockedReason2CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason an account is blocked.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BlockedReason2CodeDropdownRow(BlockedReason2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}

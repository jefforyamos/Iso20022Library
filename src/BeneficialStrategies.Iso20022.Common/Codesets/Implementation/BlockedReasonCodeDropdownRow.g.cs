﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for BlockedReasonCode.  ISO2002 ID# _iybhYxHaEeKVqeHljBM1MQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason an account is blocked.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="BlockedReasonCodeDropdownSource"/>.
/// Implements <seealso cref="IBlockedReasonCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_iybhYxHaEeKVqeHljBM1MQ")]
public partial class BlockedReasonCodeDropdownRow : EnumMetadataItem<BlockedReasonCode>, IBlockedReasonCodeDropdownRow
{
    /// <summary>
    /// Specifies the reason an account is blocked.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public BlockedReasonCodeDropdownRow(BlockedReasonCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}

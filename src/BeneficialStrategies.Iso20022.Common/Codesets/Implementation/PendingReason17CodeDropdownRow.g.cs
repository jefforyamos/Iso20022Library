﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for PendingReason17Code.  ISO2002 ID# _-bahwOBjEeiVRbNQx5-Vhg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the transaction or the instruction has a pending status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="PendingReason17CodeDropdownSource"/>.
/// Implements <seealso cref="IPendingReason17CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-bahwOBjEeiVRbNQx5-Vhg")]
public partial class PendingReason17CodeDropdownRow : EnumMetadataItem<PendingReason17Code>, IPendingReason17CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the transaction or the instruction has a pending status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public PendingReason17CodeDropdownRow(PendingReason17Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
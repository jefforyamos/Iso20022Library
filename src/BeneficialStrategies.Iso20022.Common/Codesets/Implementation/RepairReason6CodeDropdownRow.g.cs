﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for RepairReason6Code.  ISO2002 ID# _ixP4oT9qEeCY7potQsO_IA.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the reason why the securities financing instruction has a repair status.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="RepairReason6CodeDropdownSource"/>.
/// Implements <seealso cref="IRepairReason6CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ixP4oT9qEeCY7potQsO_IA")]
public partial class RepairReason6CodeDropdownRow : EnumMetadataItem<RepairReason6Code>, IRepairReason6CodeDropdownRow
{
    /// <summary>
    /// Specifies the reason why the securities financing instruction has a repair status.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public RepairReason6CodeDropdownRow(RepairReason6Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}

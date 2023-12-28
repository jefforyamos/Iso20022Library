﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for AttendanceContext2Code.  ISO2002 ID# _DnQc8JVJEeWu36UkS2TkoQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identify the method of delivery or distribution.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="AttendanceContext2CodeDropdownSource"/>.
/// Implements <seealso cref="IAttendanceContext2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DnQc8JVJEeWu36UkS2TkoQ")]
public partial class AttendanceContext2CodeDropdownRow : EnumMetadataItem<AttendanceContext2Code>, IAttendanceContext2CodeDropdownRow
{
    /// <summary>
    /// Identify the method of delivery or distribution.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public AttendanceContext2CodeDropdownRow(AttendanceContext2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
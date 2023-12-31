﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TimeSegmentCode.  ISO2002 ID# _VEH74F1lEeeu75xdwwAXQw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Segment of time of the day
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TimeSegmentCodeDropdownSource"/>.
/// Implements <seealso cref="ITimeSegmentCodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_VEH74F1lEeeu75xdwwAXQw")]
public partial class TimeSegmentCodeDropdownRow : EnumMetadataItem<TimeSegmentCode>, ITimeSegmentCodeDropdownRow
{
    /// <summary>
    /// Segment of time of the day
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TimeSegmentCodeDropdownRow(TimeSegmentCode value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}

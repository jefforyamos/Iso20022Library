﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TimeSegment1Code.  ISO2002 ID# _-A6pgF1lEeeu75xdwwAXQw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Time period of the day.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TimeSegment1CodeDropdownSource"/>.
/// Implements <seealso cref="ITimeSegment1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_-A6pgF1lEeeu75xdwwAXQw")]
public partial class TimeSegment1CodeDropdownRow : EnumMetadataItem<TimeSegment1Code>, ITimeSegment1CodeDropdownRow
{
    /// <summary>
    /// Time period of the day.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TimeSegment1CodeDropdownRow(TimeSegment1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}

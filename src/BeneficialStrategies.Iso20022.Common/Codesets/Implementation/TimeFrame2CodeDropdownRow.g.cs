﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TimeFrame2Code.  ISO2002 ID# _dMCBcMztEeq1WLK5fVzKiQ.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a time frame.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TimeFrame2CodeDropdownSource"/>.
/// Implements <seealso cref="ITimeFrame2CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dMCBcMztEeq1WLK5fVzKiQ")]
public partial class TimeFrame2CodeDropdownRow : EnumMetadataItem<TimeFrame2Code>, ITimeFrame2CodeDropdownRow
{
    /// <summary>
    /// Specifies a time frame.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TimeFrame2CodeDropdownRow(TimeFrame2Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}

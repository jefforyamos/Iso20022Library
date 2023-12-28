﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TrackerAlertStatus1Code.  ISO2002 ID# _FVgqgPryEemIKt9hrQ9pJw.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the status of the tracker alert notification.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TrackerAlertStatus1CodeDropdownSource"/>.
/// Implements <seealso cref="ITrackerAlertStatus1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_FVgqgPryEemIKt9hrQ9pJw")]
public partial class TrackerAlertStatus1CodeDropdownRow : EnumMetadataItem<TrackerAlertStatus1Code>, ITrackerAlertStatus1CodeDropdownRow
{
    /// <summary>
    /// Indicates the status of the tracker alert notification.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TrackerAlertStatus1CodeDropdownRow(TrackerAlertStatus1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}

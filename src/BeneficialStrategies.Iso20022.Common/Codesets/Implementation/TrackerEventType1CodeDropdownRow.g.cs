﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TrackerEventType1Code.  ISO2002 ID# _wQDn0HlAEei6J5_ka3EtUg.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Indicates the type of payment event.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TrackerEventType1CodeDropdownSource"/>.
/// Implements <seealso cref="ITrackerEventType1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_wQDn0HlAEei6J5_ka3EtUg")]
public partial class TrackerEventType1CodeDropdownRow : EnumMetadataItem<TrackerEventType1Code>, ITrackerEventType1CodeDropdownRow
{
    /// <summary>
    /// Indicates the type of payment event.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TrackerEventType1CodeDropdownRow(TrackerEventType1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}

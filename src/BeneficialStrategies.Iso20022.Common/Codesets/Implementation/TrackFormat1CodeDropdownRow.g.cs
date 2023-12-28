﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownRowGenerator for TrackFormat1Code.  ISO2002 ID# _ux3yUNkWEeiojJsa6FYyew.
//

using System.Reflection;

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Use to identify format of a track on a card or other documents like checks.
/// Provides values to be used in dropdown select lists and validation logic as instanced by <seealso cref="TrackFormat1CodeDropdownSource"/>.
/// Implements <seealso cref="ITrackFormat1CodeDropdownRow"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ux3yUNkWEeiojJsa6FYyew")]
public partial class TrackFormat1CodeDropdownRow : EnumMetadataItem<TrackFormat1Code>, ITrackFormat1CodeDropdownRow
{
    /// <summary>
    /// Use to identify format of a track on a card or other documents like checks.
    /// Constructs row state using the specified enum value and reflected values.
    /// </summary>
    /// <param name="value">Enum value for this row.</param>
    /// <param name="memberInfo">Reflected values specific to this row.</param>
    public TrackFormat1CodeDropdownRow(TrackFormat1Code value, MemberInfo memberInfo) : base(value, memberInfo)
    {
    }
}
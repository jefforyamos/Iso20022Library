﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TrackFormat1Code.  ISO2002 ID# _ux3yUNkWEeiojJsa6FYyew.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Use to identify format of a track on a card or other documents like checks.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITrackFormat1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ux3yUNkWEeiojJsa6FYyew")]
public partial class TrackFormat1CodeDropdownSource : EnumMetadataManager<TrackFormat1Code,ITrackFormat1CodeDropdownRow,TrackFormat1CodeDropdownRow>
{
    public TrackFormat1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TrackFormat1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

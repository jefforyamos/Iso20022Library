﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for MeetingType3Code.  ISO2002 ID# _3APSkFuKEeSmO6RkXg92Lg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of security holders meeting.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IMeetingType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_3APSkFuKEeSmO6RkXg92Lg")]
public partial class MeetingType3CodeDropdownSource : EnumMetadataManager<MeetingType3Code,IMeetingType3CodeDropdownRow,MeetingType3CodeDropdownRow>
{
    public MeetingType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new MeetingType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

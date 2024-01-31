﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for AttendanceContext2Code.  ISO2002 ID# _DnQc8JVJEeWu36UkS2TkoQ.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Identify the method of delivery or distribution.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IAttendanceContext2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_DnQc8JVJEeWu36UkS2TkoQ")]
public partial class AttendanceContext2CodeDropdownSource : EnumMetadataManager<AttendanceContext2Code,IAttendanceContext2CodeDropdownRow,AttendanceContext2CodeDropdownRow>
{
    public AttendanceContext2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new AttendanceContext2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DateModeCode.  ISO2002 ID# _NR5vEFuREeSmO6RkXg92Lg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies, for a date, when the event or operation is to take place, for example at the beginning or end of the day.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDateModeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_NR5vEFuREeSmO6RkXg92Lg")]
public partial class DateModeCodeDropdownSource : EnumMetadataManager<DateModeCode,IDateModeCodeDropdownRow,DateModeCodeDropdownRow>
{
    public DateModeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DateModeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

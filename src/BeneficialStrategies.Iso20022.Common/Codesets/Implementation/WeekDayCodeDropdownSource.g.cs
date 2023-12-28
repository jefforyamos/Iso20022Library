﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for WeekDayCode.  ISO2002 ID# _vVeyEA3eEeW9YKj3GUmIEw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the day of the week of the delivery.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IWeekDayCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_vVeyEA3eEeW9YKj3GUmIEw")]
public partial class WeekDayCodeDropdownSource : EnumMetadataManager<WeekDayCode,IWeekDayCodeDropdownRow,WeekDayCodeDropdownRow>
{
    public WeekDayCodeDropdownSource()
        : base( (enumValue, memberInfo) => new WeekDayCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
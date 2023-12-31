﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for WeekDay2Code.  ISO2002 ID# _AgPzYS-pEeWvZpCvNOLJLQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the day of the week of the delivery.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IWeekDay2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_AgPzYS-pEeWvZpCvNOLJLQ")]
public partial class WeekDay2CodeDropdownSource : EnumMetadataManager<WeekDay2Code,IWeekDay2CodeDropdownRow,WeekDay2CodeDropdownRow>
{
    public WeekDay2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new WeekDay2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

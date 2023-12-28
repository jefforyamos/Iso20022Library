﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for WeekDay3Code.  ISO2002 ID# _ybdoIJDpEeiZrojxmnmDSQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the day of the week of the delivery.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IWeekDay3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ybdoIJDpEeiZrojxmnmDSQ")]
public partial class WeekDay3CodeDropdownSource : EnumMetadataManager<WeekDay3Code,IWeekDay3CodeDropdownRow,WeekDay3CodeDropdownRow>
{
    public WeekDay3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new WeekDay3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

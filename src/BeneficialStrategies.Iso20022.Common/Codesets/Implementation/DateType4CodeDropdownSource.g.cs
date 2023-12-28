﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DateType4Code.  ISO2002 ID# _ayZwpNp-Ed-ak6NoX_4Aeg_-1040840411.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a type of date.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDateType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ayZwpNp-Ed-ak6NoX_4Aeg_-1040840411")]
public partial class DateType4CodeDropdownSource : EnumMetadataManager<DateType4Code,IDateType4CodeDropdownRow,DateType4CodeDropdownRow>
{
    public DateType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DateType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
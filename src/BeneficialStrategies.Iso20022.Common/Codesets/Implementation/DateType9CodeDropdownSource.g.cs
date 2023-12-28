﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DateType9Code.  ISO2002 ID# _cgm0oO4EEeqc-LCjwLsUVg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Date is specified as a fixed code value.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDateType9CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_cgm0oO4EEeqc-LCjwLsUVg")]
public partial class DateType9CodeDropdownSource : EnumMetadataManager<DateType9Code,IDateType9CodeDropdownRow,DateType9CodeDropdownRow>
{
    public DateType9CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DateType9CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
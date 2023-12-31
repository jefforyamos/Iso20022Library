﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DateType1Code.  ISO2002 ID# _ayQmt9p-Ed-ak6NoX_4Aeg_-400780880.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies when date is unknown.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDateType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ayQmt9p-Ed-ak6NoX_4Aeg_-400780880")]
public partial class DateType1CodeDropdownSource : EnumMetadataManager<DateType1Code,IDateType1CodeDropdownRow,DateType1CodeDropdownRow>
{
    public DateType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new DateType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

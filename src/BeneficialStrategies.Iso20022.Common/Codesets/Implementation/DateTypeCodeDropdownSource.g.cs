﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DateTypeCode.  ISO2002 ID# _ayjhp9p-Ed-ak6NoX_4Aeg_-2092185589.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Ongoing basis, which indicates that the date is determined by "ongoing basis" process, for example "au fil de l'eau".
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDateTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_ayjhp9p-Ed-ak6NoX_4Aeg_-2092185589")]
public partial class DateTypeCodeDropdownSource : EnumMetadataManager<DateTypeCode,IDateTypeCodeDropdownRow,DateTypeCodeDropdownRow>
{
    public DateTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DateTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
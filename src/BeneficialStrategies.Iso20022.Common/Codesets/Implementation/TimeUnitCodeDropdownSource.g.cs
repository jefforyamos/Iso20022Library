﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TimeUnitCode.  ISO2002 ID# _YmCmwNp-Ed-ak6NoX_4Aeg_-22472882.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the time unit.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITimeUnitCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YmCmwNp-Ed-ak6NoX_4Aeg_-22472882")]
public partial class TimeUnitCodeDropdownSource : EnumMetadataManager<TimeUnitCode,ITimeUnitCodeDropdownRow,TimeUnitCodeDropdownRow>
{
    public TimeUnitCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TimeUnitCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
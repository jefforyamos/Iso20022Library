﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TimeFrame2Code.  ISO2002 ID# _dMCBcMztEeq1WLK5fVzKiQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a time frame.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITimeFrame2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_dMCBcMztEeq1WLK5fVzKiQ")]
public partial class TimeFrame2CodeDropdownSource : EnumMetadataManager<TimeFrame2Code,ITimeFrame2CodeDropdownRow,TimeFrame2CodeDropdownRow>
{
    public TimeFrame2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new TimeFrame2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
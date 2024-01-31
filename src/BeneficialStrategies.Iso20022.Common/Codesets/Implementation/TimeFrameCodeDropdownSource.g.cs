﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for TimeFrameCode.  ISO2002 ID# _EKEEgDccEeidBoT_PugKiA.
//

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a time frame.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="ITimeFrameCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_EKEEgDccEeidBoT_PugKiA")]
public partial class TimeFrameCodeDropdownSource : EnumMetadataManager<TimeFrameCode,ITimeFrameCodeDropdownRow,TimeFrameCodeDropdownRow>
{
    public TimeFrameCodeDropdownSource()
        : base( (enumValue, memberInfo) => new TimeFrameCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

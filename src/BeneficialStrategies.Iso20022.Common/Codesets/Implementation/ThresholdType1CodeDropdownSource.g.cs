﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ThresholdType1Code.  ISO2002 ID# _YgYDotp-Ed-ak6NoX_4Aeg_-651849166.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Defines whether the threshold was applied on an unsecured or securited basis.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IThresholdType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YgYDotp-Ed-ak6NoX_4Aeg_-651849166")]
public partial class ThresholdType1CodeDropdownSource : EnumMetadataManager<ThresholdType1Code,IThresholdType1CodeDropdownRow,ThresholdType1CodeDropdownRow>
{
    public ThresholdType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ThresholdType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DividendRateTypeCode.  ISO2002 ID# _axET5tp-Ed-ak6NoX_4Aeg_-411764395.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the type of dividend rate.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDividendRateTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_axET5tp-Ed-ak6NoX_4Aeg_-411764395")]
public partial class DividendRateTypeCodeDropdownSource : EnumMetadataManager<DividendRateTypeCode,IDividendRateTypeCodeDropdownRow,DividendRateTypeCodeDropdownRow>
{
    public DividendRateTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DividendRateTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
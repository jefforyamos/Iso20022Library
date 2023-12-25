﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for DividendTypeCode.  ISO2002 ID# _axNd2dp-Ed-ak6NoX_4Aeg_-1189024253.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the nature of the dividend.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IDividendTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_axNd2dp-Ed-ak6NoX_4Aeg_-1189024253")]
public partial class DividendTypeCodeDropdownSource : EnumMetadataManager<DividendTypeCode,IDividendTypeCodeDropdownRow,DividendTypeCodeDropdownRow>
{
    public DividendTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new DividendTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

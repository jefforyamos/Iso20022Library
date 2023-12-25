﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureTypeCode.  ISO2002 ID# _alvNodp-Ed-ak6NoX_4Aeg_1976296742.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Short sale exposure.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_alvNodp-Ed-ak6NoX_4Aeg_1976296742")]
public partial class ExposureTypeCodeDropdownSource : EnumMetadataManager<ExposureTypeCode,IExposureTypeCodeDropdownRow,ExposureTypeCodeDropdownRow>
{
    public ExposureTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureConventionTypeCode.  ISO2002 ID# _YczLM9p-Ed-ak6NoX_4Aeg_-483728852.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Determines how the variation margin requirement will be calculated, either net or gross.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureConventionTypeCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YczLM9p-Ed-ak6NoX_4Aeg_-483728852")]
public partial class ExposureConventionTypeCodeDropdownSource : EnumMetadataManager<ExposureConventionTypeCode,IExposureConventionTypeCodeDropdownRow,ExposureConventionTypeCodeDropdownRow>
{
    public ExposureConventionTypeCodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureConventionTypeCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
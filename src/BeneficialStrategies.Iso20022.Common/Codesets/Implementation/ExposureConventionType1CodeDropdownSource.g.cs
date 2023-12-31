﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureConventionType1Code.  ISO2002 ID# _YczLMNp-Ed-ak6NoX_4Aeg_945714582.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Determines how the variation margin requirement will be calculated, either net or gross.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureConventionType1CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_YczLMNp-Ed-ak6NoX_4Aeg_945714582")]
public partial class ExposureConventionType1CodeDropdownSource : EnumMetadataManager<ExposureConventionType1Code,IExposureConventionType1CodeDropdownRow,ExposureConventionType1CodeDropdownRow>
{
    public ExposureConventionType1CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureConventionType1CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

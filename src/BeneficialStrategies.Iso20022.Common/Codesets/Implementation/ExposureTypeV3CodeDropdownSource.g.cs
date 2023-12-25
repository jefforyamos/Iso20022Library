﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureTypeV3Code.  ISO2002 ID# _7qsobiW3EeyT3chuyX0PgA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureTypeV3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_7qsobiW3EeyT3chuyX0PgA")]
public partial class ExposureTypeV3CodeDropdownSource : EnumMetadataManager<ExposureTypeV3Code,IExposureTypeV3CodeDropdownRow,ExposureTypeV3CodeDropdownRow>
{
    public ExposureTypeV3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureTypeV3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

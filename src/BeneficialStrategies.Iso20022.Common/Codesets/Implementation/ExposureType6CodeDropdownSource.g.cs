﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureType6Code.  ISO2002 ID# _UIVnYHaaEeavseMKyTsJEA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Identification of the type of the transaction.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureType6CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_UIVnYHaaEeavseMKyTsJEA")]
public partial class ExposureType6CodeDropdownSource : EnumMetadataManager<ExposureType6Code,IExposureType6CodeDropdownRow,ExposureType6CodeDropdownRow>
{
    public ExposureType6CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureType6CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

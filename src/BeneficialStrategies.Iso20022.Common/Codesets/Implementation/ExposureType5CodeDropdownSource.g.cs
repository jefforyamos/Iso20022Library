﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureType5Code.  ISO2002 ID# _Fa8SEGNhEeSLD8nyfZcLzQ.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureType5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Fa8SEGNhEeSLD8nyfZcLzQ")]
public partial class ExposureType5CodeDropdownSource : EnumMetadataManager<ExposureType5Code,IExposureType5CodeDropdownRow,ExposureType5CodeDropdownRow>
{
    public ExposureType5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureType5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

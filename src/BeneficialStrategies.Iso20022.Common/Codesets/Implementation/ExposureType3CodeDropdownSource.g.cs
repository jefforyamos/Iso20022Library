﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureType3Code.  ISO2002 ID# __18hkdojEeC60axPepSq7g_133029952.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureType3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__18hkdojEeC60axPepSq7g_133029952")]
public partial class ExposureType3CodeDropdownSource : EnumMetadataManager<ExposureType3Code,IExposureType3CodeDropdownRow,ExposureType3CodeDropdownRow>
{
    public ExposureType3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureType3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
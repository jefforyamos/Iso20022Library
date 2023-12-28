﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureType12Code.  ISO2002 ID# __WpdESglEey2k_sfZmJz4g.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureType12CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("__WpdESglEey2k_sfZmJz4g")]
public partial class ExposureType12CodeDropdownSource : EnumMetadataManager<ExposureType12Code,IExposureType12CodeDropdownRow,ExposureType12CodeDropdownRow>
{
    public ExposureType12CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureType12CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ExposureType4Code.  ISO2002 ID# _QEjGACT3EeOSHvJr_wacAw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the underlying business area/type of trade causing the collateral movement.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IExposureType4CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QEjGACT3EeOSHvJr_wacAw")]
public partial class ExposureType4CodeDropdownSource : EnumMetadataManager<ExposureType4Code,IExposureType4CodeDropdownRow,ExposureType4CodeDropdownRow>
{
    public ExposureType4CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ExposureType4CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

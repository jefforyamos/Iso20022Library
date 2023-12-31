﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BaselineStatus3Code.  ISO2002 ID# _bcugAtp-Ed-ak6NoX_4Aeg_-310506131.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the status of a baseline.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBaselineStatus3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bcugAtp-Ed-ak6NoX_4Aeg_-310506131")]
public partial class BaselineStatus3CodeDropdownSource : EnumMetadataManager<BaselineStatus3Code,IBaselineStatus3CodeDropdownRow,BaselineStatus3CodeDropdownRow>
{
    public BaselineStatus3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BaselineStatus3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

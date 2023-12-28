﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BaselineStatus2Code.  ISO2002 ID# _bckvBdp-Ed-ak6NoX_4Aeg_-554101264.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the status requested to be assigned to the baseline.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBaselineStatus2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bckvBdp-Ed-ak6NoX_4Aeg_-554101264")]
public partial class BaselineStatus2CodeDropdownSource : EnumMetadataManager<BaselineStatus2Code,IBaselineStatus2CodeDropdownRow,BaselineStatus2CodeDropdownRow>
{
    public BaselineStatus2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BaselineStatus2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}
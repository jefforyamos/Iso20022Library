﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BaselineStatusCode.  ISO2002 ID# _bc3p9dp-Ed-ak6NoX_4Aeg_-1712185588.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Indicates the status of a baseline.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBaselineStatusCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_bc3p9dp-Ed-ak6NoX_4Aeg_-1712185588")]
public partial class BaselineStatusCodeDropdownSource : EnumMetadataManager<BaselineStatusCode,IBaselineStatusCodeDropdownRow,BaselineStatusCodeDropdownRow>
{
    public BaselineStatusCodeDropdownSource()
        : base( (enumValue, memberInfo) => new BaselineStatusCodeDropdownRow(enumValue, memberInfo))
    {
    }
}

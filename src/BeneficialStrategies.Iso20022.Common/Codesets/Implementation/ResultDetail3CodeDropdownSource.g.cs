﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for ResultDetail3Code.  ISO2002 ID# _Z3kk4I4YEeW6h7rGyYlyTg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Detail of the response.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IResultDetail3CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_Z3kk4I4YEeW6h7rGyYlyTg")]
public partial class ResultDetail3CodeDropdownSource : EnumMetadataManager<ResultDetail3Code,IResultDetail3CodeDropdownRow,ResultDetail3CodeDropdownRow>
{
    public ResultDetail3CodeDropdownSource()
        : base( (enumValue, memberInfo) => new ResultDetail3CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

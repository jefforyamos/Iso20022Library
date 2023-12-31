﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BenchmarkCurveName5Code.  ISO2002 ID# _QTZ7bijFEeuKKc2MztSwPw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a benchmark curve name.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBenchmarkCurveName5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QTZ7bijFEeuKKc2MztSwPw")]
public partial class BenchmarkCurveName5CodeDropdownSource : EnumMetadataManager<BenchmarkCurveName5Code,IBenchmarkCurveName5CodeDropdownRow,BenchmarkCurveName5CodeDropdownRow>
{
    public BenchmarkCurveName5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BenchmarkCurveName5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

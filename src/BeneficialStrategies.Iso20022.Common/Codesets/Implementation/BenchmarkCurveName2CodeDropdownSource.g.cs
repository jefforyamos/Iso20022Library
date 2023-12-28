﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for BenchmarkCurveName2Code.  ISO2002 ID# _QEXIYAnUEeWa7rBfPECYsw.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies a benchmark curve name.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IBenchmarkCurveName2CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_QEXIYAnUEeWa7rBfPECYsw")]
public partial class BenchmarkCurveName2CodeDropdownSource : EnumMetadataManager<BenchmarkCurveName2Code,IBenchmarkCurveName2CodeDropdownRow,BenchmarkCurveName2CodeDropdownRow>
{
    public BenchmarkCurveName2CodeDropdownSource()
        : base( (enumValue, memberInfo) => new BenchmarkCurveName2CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

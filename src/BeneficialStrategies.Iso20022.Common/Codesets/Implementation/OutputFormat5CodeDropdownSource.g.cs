﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OutputFormat5Code.  ISO2002 ID# _M3WN8MlUEeuJ35KoBRZFOg.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Specifies the format of the data.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOutputFormat5CodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_M3WN8MlUEeuJ35KoBRZFOg")]
public partial class OutputFormat5CodeDropdownSource : EnumMetadataManager<OutputFormat5Code,IOutputFormat5CodeDropdownRow,OutputFormat5CodeDropdownRow>
{
    public OutputFormat5CodeDropdownSource()
        : base( (enumValue, memberInfo) => new OutputFormat5CodeDropdownRow(enumValue, memberInfo))
    {
    }
}

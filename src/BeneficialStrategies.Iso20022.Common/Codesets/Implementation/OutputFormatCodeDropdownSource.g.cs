﻿//
// GENERATED CODE, DO NOT EDIT THIS FILE!
//
// Generated by DropdownSourceGenerator for OutputFormatCode.  ISO2002 ID# _tW6kUHr5EeSZrs_hiwNOWA.
//

namespace BeneficialStrategies.Iso20222.Common;

/// <summary>
/// Available message format to display or print.
/// Provides values to be used in dropdown select lists and validation logic.
/// Implements <seealso cref="IOutputFormatCodeDropdownSource"/> by obtaining row data from the metadata contained within the codebase.
/// </summary>
[IsoId("_tW6kUHr5EeSZrs_hiwNOWA")]
public partial class OutputFormatCodeDropdownSource : EnumMetadataManager<OutputFormatCode,IOutputFormatCodeDropdownRow,OutputFormatCodeDropdownRow>
{
    public OutputFormatCodeDropdownSource()
        : base( (enumValue, memberInfo) => new OutputFormatCodeDropdownRow(enumValue, memberInfo))
    {
    }
}
